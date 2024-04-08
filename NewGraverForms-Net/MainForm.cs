using GraverLibrary.Models;
using GraverLibrary.Models.Common;
using GraverLibrary.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NewGraverForms_Net.Exceptions.Serial;
using NewGraverForms_Net.Services.Common;
using NewGraverForms_Net.Tools;
using Serilog;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO.Ports;
using System.Net;
using System.Text.Json;

namespace NewGraverForms_Net
{
    public partial class MainForm : Form
    {

        private const int MAX_PORT = 65535;
        private const int COUNT_IPV4_BLOCKS = 4;
        private readonly TabControlHelper _tabControlHelper;
        private readonly IBaseMarkerService _graverService;
        private readonly IHeightService _heightService;
        private readonly ILogger<MainForm> _logger;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _serialPortSection;
        private readonly IConfigurationSection _materialsSection;

        public MainForm(
            IBaseMarkerService graverService,
            IConfiguration cfg,
            ILogger<MainForm> logger,
            IHeightService heightService
            )
        {
            InitializeComponent();
            _tabControlHelper = InitTabControlHelper(mainTabControl);
            _heightService = heightService;
            _graverService = graverService;
            _logger = logger;
            _configuration = cfg;
            _serialPortSection = _configuration.GetSection("SerialRangeMeter");
            _materialsSection = _configuration.GetSection("MaterialConfiguration");
            InitButtons();
            InitActions();
            InitComboBoxMaterial();
            _logger.LogWarning(Properties.Settings.Default.apiKey);
            _logger.LogWarning(_configuration?.GetConnectionString("sql"));

        }

        private void InitActions()
        {
            _graverService.Connected += OnConnected;
            _graverService.ProgressSendFile += OnProgressSendFile;

        }

        private void InitButtons()
        {
            buttonNextTab.Enabled = false;
        }

        #region ConnectionPage
        private async void buttonConnection_Click(object sender, EventArgs e)
        {
            if (textBoxConnectionHost.Text.Split('.').Length == COUNT_IPV4_BLOCKS)
            {
                return;
            }
            if (!int.TryParse(textBoxConnectionPort.Text, out int port) || port < 1 || port > MAX_PORT)
            {
                return;
            }

            // await _graverService.TryConnectAsync(IPAddress.Parse(textBoxConnectionHost.Text), port);
        }

        private void textBoxConnectionHost_KeyPress(object IpAddressTextBox, KeyPressEventArgs e)
        {
            var blocks = ((TextBox)IpAddressTextBox).Text.Split('.');
            bool canAppendPoint = e.KeyChar == '.' && ((TextBox)IpAddressTextBox).Text.LastOrDefault() != '.';
            if (canAppendPoint && (blocks.Length < COUNT_IPV4_BLOCKS))
            {
                ((TextBox)IpAddressTextBox).AppendText(".");
                e.Handled = true;
                return;
            }
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (blocks.Length == COUNT_IPV4_BLOCKS)
            {
                if (int.Parse(blocks[COUNT_IPV4_BLOCKS - 1] + e.KeyChar) >= 255)
                {
                    e.Handled = true;
                    return;
                }

            }
            if (blocks.Length < COUNT_IPV4_BLOCKS)
            {
                var currentNum = int.Parse(blocks[blocks.Length - 1] + e.KeyChar + '0');
                if (currentNum >= 255)
                {
                    ((TextBox)IpAddressTextBox).AppendText(e.KeyChar.ToString());
                    ((TextBox)IpAddressTextBox).AppendText(".");
                    e.Handled = true;
                }
            }
        }

        private void textBoxConnectionPort_KeyPress(object portTextBox, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


            if (int.TryParse(((TextBox)portTextBox).Text, out int port) & port * 10 > MAX_PORT & !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnConnected()
        {
            labelIsConnected.Text = "Success";
            labelIsConnected.ForeColor = Color.Green;
            buttonNextTab.Enabled = true;
        }
        #endregion ConnectionPage

        #region ChoiceFile

        private async void button_selectFile_Click(object sender, EventArgs e)
        {
            buttonNextTab.Enabled = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "le|*.le";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                _logger.LogWarning("Выбор файла отменён");
                return;
            }
            var pathLeFile = openFileDialog.FileName;
            _logger.LogInformation("Выбранный файл: " + pathLeFile);

            var result = await _graverService.SendFile(new FileStream(pathLeFile, FileMode.Open));
            if (result)
            {
                label_selectedFile.Text = _graverService.GetFileName();
                buttonNextTab.Enabled = true;
            }
            else
            {
                var mb = MessageBox.Show("The file was not loaded.\r\n Improve your connection and repeat!", "Something went wrong!", MessageBoxButtons.OK);
            }
        }

        private async void OnProgressSendFile(int percent)
        {
            label_selectedFile.Text = percent.ToString() + "%";
        }
        #endregion ChoiceFile

        #region Axes XY

        private void buttonAxisControl_Click(object sender, EventArgs e)
        {
            FormAxis form = new FormAxis(_graverService);
            form.Owner = this;
            form.Show();
        }

        private void checkBoxAxesPosition_CheckedChanged(object checkBox, EventArgs e)
        {
            buttonNextTab.Enabled = ((CheckBox)checkBox).Checked;
        }

        #endregion Axes XY

        #region Height Page

        private void button_set_auto_height_Click(object sender, EventArgs e)
        {
            int height = _heightService.GetHeightToObj();
            labelAutoHeight.Text = height.ToString() + " mm";
            //_service.SetHeightToObject(height);
        }

        private void buttonAcceptHeight_Click(object sender, EventArgs e)
        {
            if (string.Compare(textBoxHeight.Text, "", ignoreCase: true, culture: CultureInfo.InvariantCulture) == 0)
            {
                return;
            }
            _graverService.SetHeightToObject(int.Parse(textBoxHeight.Text));
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion Height Page

        #region MaterialPage

        private void InitComboBoxMaterial()
        {
            _logger.LogInformation(nameof(InitComboBoxMaterial) + DateTime.Now);
            var materialArray = _materialsSection.GetSection("Material").Get<Material[]>();
            comboBoxMaterial.Items.AddRange(materialArray);
            comboBoxMaterial.DisplayMember = nameof(Material.Name);
        }

        private void buttonApplyMaterial_Click(object comboBoxMaterial, EventArgs e)
        {
            var selectedMaterial = ((ComboBox)comboBoxMaterial).SelectedItem as Material;
            _graverService.SetPowerMode(selectedMaterial);
        }
        #endregion MaterialPage

        #region PagesControl
        private TabControlHelper InitTabControlHelper(TabControl tabControl)
        {
            var helper = new TabControlHelper(mainTabControl);
            helper.OnFirstPage += OnFirstTab;
            helper.OnLastPage += OnLastTab;
            helper.OnPageChanged += OnAnotherTab;
            helper.HideAllPages();
            helper.ShowPage(0);
            helper.CurrentIndex = 0;
            return helper;
        }

        private void buttonNextTab_Click(object sender, EventArgs e)
        {
            _tabControlHelper.ShowNextOne();
            buttonNextTab.Enabled = false;
        }

        private void OnFirstTab()
        {
            buttonBackTab.Hide();
        }

        private void OnLastTab()
        {
            buttonNextTab.Hide();
        }

        private void OnAnotherTab()
        {
            buttonBackTab.Show();
            buttonNextTab.Show();
        }

        private void buttonBackTab_Click(object sender, EventArgs e)
        {
            _tabControlHelper.ShowPrevOne();
        }
        #endregion PagesControl

        
    }
}
