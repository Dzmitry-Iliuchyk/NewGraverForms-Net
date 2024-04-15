using GraverLibrary.Models;
using GraverLibrary.Models.Common;
using GraverLibrary.Services.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NewGraverForms_Net.Exceptions.Serial;
using NewGraverForms_Net.Services.Common;
using NewGraverForms_Net.Tools;
using System.Net;
using System.Text.Json;

namespace NewGraverForms_Net
{
    public partial class MainForm : Form
    {
        private List<Order> orders = new List<Order>();
        static int MarkingCount = 0;
        private const int MAX_PORT = 65535;
        private const int COUNT_IPV4_BLOCKS = 4;
        private readonly TabControlHelper _tabControlHelper;
        private readonly IBaseMarkerService _graverService;
        private readonly IHeightService _heightService;
        private readonly ILogger<MainForm> _logger;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _serialPortSection;
        private readonly IConfigurationSection _materialsSection;
        private readonly FormAxis _formAxis;

        public MainForm(
            IBaseMarkerService graverService,
            IConfiguration cfg,
            ILogger<MainForm> logger,
            IHeightService heightService,
            FormAxis formAxis
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
            _formAxis = formAxis;
            InitButtons();
            InitActions();
            InitComboBoxMaterial();
        }

        private void InitActions()
        {
            _graverService.Connected += OnConnected;
            _graverService.ProgressSendFile += OnProgressSendFile;
            _graverService.HeightIsSet += OnHeightSetted;
            _graverService.markingFinished += OnMarkingFinished;
            _graverService.PowerModIsSet += OnPowerModeIsSet;
        }

        private void InitButtons()
        {
            buttonNextTab.Enabled = false;
        }

        #region ConnectionPage

        private async void buttonConnection_Click(object sender, EventArgs e)
        {
            bool isIpValid = true, isHostValid = true;
            if (textBoxConnectionHost.Text.Split('.').Length < COUNT_IPV4_BLOCKS)
            {
                labelConnectionHost.ForeColor = Color.Red;
                isIpValid = false;
            }
            else
            {
                labelConnectionHost.ForeColor = Color.Black;
            }
            if (!int.TryParse(textBoxConnectionPort.Text, out int port) || port < 1 || port > MAX_PORT)
            {
                labelConnectionPort.ForeColor = Color.Red;
                isHostValid = false;
            }
            else
            {
                labelConnectionPort.ForeColor = Color.Black;
            }
            if (!isIpValid || !isHostValid)
            {
                return;
            }
            await _graverService.TryConnectAsync(IPAddress.Parse(textBoxConnectionHost.Text), port);
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
            DisableButtonsWhileLoadFile();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "le|*.le";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                _logger.LogWarning(nameof(button_selectFile_Click) + " Выбор файла отменён");
                return;
            }
            var pathLeFile = openFileDialog.FileName;
            _logger.LogInformation(nameof(button_selectFile_Click) + "Выбранный файл: " + pathLeFile);

            var result = await _graverService.SendFile(new FileStream(pathLeFile, FileMode.Open));
            if (result)
            {
                _logger.LogInformation(nameof(button_selectFile_Click) + " Выбор файла отменён");
                label_selectedFile.Text = Path.GetFileName(pathLeFile);
                buttonNextTab.Enabled = true;
            }
            else
            {
                _logger.LogError(nameof(button_selectFile_Click) + " The file was not loaded.");
                var mb = MessageBox.Show("The file was not loaded.\r\n Improve your connection and repeat!", "Something went wrong!", MessageBoxButtons.OK);
            }
            EnableButtonsWhileLoadFile();
        }

        private void DisableButtonsWhileLoadFile()
        {
            buttonNextTab.Enabled = false;
            buttonBackTab.Enabled = false;
            button_selectFile.Enabled = false;
        }
        private void EnableButtonsWhileLoadFile()
        {
            buttonBackTab.Enabled = true;
            button_selectFile.Enabled = true;
        }

        private async void OnProgressSendFile(int percent)
        {
            label_selectedFile.Text = percent.ToString() + "%";
        }

        private void checkBoxAgreeFile_CheckedChanged(object sender, EventArgs e)
        {
            buttonNextTab.Enabled = checkBoxAgreeFile.Checked;
            if (checkBoxAgreeFile.Checked)
            {
                _graverService.CheckCurrentFile();
            }
        }

        private void buttonSelectOrder_Click(object sender, EventArgs e)
        {
            List<Order> orders = new List<Order>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "json|*.json";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                _logger.LogWarning(nameof(buttonSelectOrder_Click) + " Выбор файла отменён");
                return;
            }
            var pathOrderFile = openFileDialog.FileName;
            labelOrderFile.Text = Path.GetFileName(pathOrderFile);
            _logger.LogInformation(nameof(buttonSelectOrder_Click) + "Выбранный файл: " + pathOrderFile);
            orders = JsonSerializer.Deserialize<List<Order>>(File.OpenRead(pathOrderFile));

        }

        #endregion ChoiceFile

        #region Axes XY

        private void buttonAxisControl_Click(object sender, EventArgs e)
        {
            _formAxis.ShowDialog();
        }

        private void checkBoxAxesPosition_CheckedChanged(object checkBox, EventArgs e)
        {
            buttonNextTab.Enabled = ((CheckBox)checkBox).Checked;
        }

        #endregion Axes XY

        #region Height Page

        private void button_set_auto_height_Click(object sender, EventArgs e)
        {
            try
            {
                int height = _heightService.GetHeightToObj();
                labelAutoHeight.Text = height.ToString() + " mm";
                _graverService.SetHeightToObject(height);
            }
            catch (SerialPortException ex)
            {
                _logger.LogError(nameof(button_set_auto_height_Click) + ex.Message);
                labelAutoHeight.Text = "Error";
            }
            catch (IOException ioExc)
            {
                _logger.LogError(nameof(button_set_auto_height_Click) + ioExc.Message);
                throw;
            }
        }

        private void buttonAcceptHeight_Click(object sender, EventArgs e)
        {
            if (string.Compare(textBoxHeight.Text, "", ignoreCase: true, culture: System.Globalization.CultureInfo.InvariantCulture) == 0)
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
        private void OnHeightSetted()
        {
            buttonNextTab.Enabled = true;
        }

        private void checkBoxHeight_CheckedChanged(object sender, EventArgs e)
        {
            buttonNextTab.Enabled = ((CheckBox)sender).Checked;
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

        private void buttonApplyMaterial_Click(object btnAdmitMaterial, EventArgs e)
        {
            var selectedMaterial = comboBoxMaterial.SelectedItem as Material;
            var result = _graverService.SetPowerMode(selectedMaterial);
            MessageBox.Show(result);
        }

        private void checkBoxMaterial_CheckedChanged(object sender, EventArgs e)
        {
            buttonNextTab.Enabled = ((CheckBox)sender).Checked;
        }

        private void OnPowerModeIsSet()
        {
            buttonNextTab.Enabled = true;
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

        #region StartPage
        private void buttonManualStart_Click(object sender, EventArgs e)
        {
            BlockButtonsForMarkingManual();
            _graverService.StartMarkOnce();
        }
        CancellationTokenSource cancelTokenSource;
        public CancellationToken token;
        private bool IsDetailReady = false;

        private void buttonAutoStart_Click(object sender, EventArgs e)
        {
            DisableButtonsWhileAutoMarking();
            cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token;

            var setListenerMode = new Task(() => SetListenerMode(), token);
            setListenerMode.Start();
            EnableButtonsWhileAutoMarking();

        }

        private void EnableButtonsWhileAutoMarking()
        {
            buttonBackTab.Enabled = true;
            buttonManualStart.Enabled = true; 
            buttonAutoStart.Enabled = true;
        }

        private void DisableButtonsWhileAutoMarking()
        {
            buttonBackTab.Enabled = false;
            buttonManualStart.Enabled = false;
            buttonAutoStart.Enabled = false;
        }

        private Task SetListenerMode()
        {
            while (!token.IsCancellationRequested)
            {
                //IsDetailReady = Convert.ToBoolean(RoboReader);
                if (_graverService.IsGrafAvailableForMarking && IsDetailReady)
                {
                    IsDetailReady = false;
                    var ordersToMark = orders.Where(x => x.IsMarked == false).ToList();
                    if (ordersToMark.Count() > 0)
                    {
                        var order = ordersToMark.First();
                        _graverService.SetValueBeforeMarking(order);
                    }
                    _graverService.StartMarkOnce();
                }
            }
            return Task.CompletedTask;
        }
        private void buttonAutoStop_Click(object sender, EventArgs e)
        {
            cancelTokenSource.Cancel();
        }

        private void OnMarkingFinished()
        {
            MarkingCount++;
            _logger?.LogInformation(nameof(OnMarkingFinished) + DateTime.Now + "MarkingNum" + MarkingCount);
        }

        private void BlockButtonsForMarkingManual()
        {
            buttonBackTab.Enabled = false;
            buttonAutoStart.Enabled = false;
            buttonAutoStop.Enabled = false;
            buttonManualStart.Enabled = false;
        }
        private void buttonDetailReady_Click(object sender, EventArgs e)
        {
            IsDetailReady = true;
        }
        #endregion StartPage


        
    }

}
