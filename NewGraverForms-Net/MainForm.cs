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
            InitComboBox();
            _logger.LogWarning(Properties.Settings.Default.apiKey);
            _logger.LogWarning(_configuration?.GetConnectionString("sql"));

        }

        private void InitActions()
        {
            _graverService.Connected += OnConnected;
        }

        private void OnConnected()
        {
            labelIsConnected.Text = "Success";
            labelIsConnected.ForeColor = Color.Green;
            buttonNextTab.Enabled = true;
        }

        private void InitButtons()
        {
            buttonNextTab.Enabled = false;
        }

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

        private void InitComboBox()
        {
            _logger.LogInformation(nameof(InitComboBox) + DateTime.Now);
            var materialArray = _materialsSection.GetSection("Material").Get<Material[]>();
            comboBoxMaterial.Items.AddRange(materialArray);
            comboBoxMaterial.DisplayMember = nameof(Material.Name);
        }

        private void buttonAxisControl_Click(object sender, EventArgs e)
        {
            FormAxis form = new FormAxis(_graverService);
            form.Owner = this;
            form.Show();
        }


        private void button_selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "le|*.le";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                _logger.LogWarning("Выбор файла отменён");
                return;
            }
            var pathLeFile = openFileDialog.FileName;
            _logger.LogInformation("Выбранный файл: " + pathLeFile);

            _graverService.SendFile(new FileStream(pathLeFile, FileMode.Open));

        }

        private void button_set_auto_height_Click(object sender, EventArgs e)
        {
            int height = _heightService.GetHeightToObj();
            labelAutoHeight.Text = height.ToString() + " mm";
            //_service.SetHeightToObject(height);
        }

        private async void buttonConnection_Click(object sender, EventArgs e)
        {
            if (textBoxConnectionHost.Text.Split('.').Length == COUNT_IPV4_BLOCKS)
            {
                return;
            }
            if (!int.TryParse(textBoxConnectionPort.Text, out int port)||port<1||port>MAX_PORT)
            {
                return;
            }
            await _graverService.TryConnectAsync(IPAddress.Parse(textBoxConnectionHost.Text),port);
        }

        private void textBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxConnectionHost_KeyPress(object IpAddressTextBox, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            var blocks = ((TextBox)IpAddressTextBox).Text.Split('.');
            
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

            
            if (int.Parse(((TextBox)portTextBox).Text) > MAX_PORT)
            {
                e.Handled = true;
            }
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

        private void buttonAcceptHeight_Click(object sender, EventArgs e)
        {
            if (string.Compare(textBoxHeight.Text,"",ignoreCase: true,culture: CultureInfo.InvariantCulture)==0)
            {
                return;
            }
            _graverService.SetHeightToObject(int.Parse(textBoxHeight.Text));
        }
    }
}
