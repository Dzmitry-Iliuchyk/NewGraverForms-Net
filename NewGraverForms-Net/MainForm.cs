using GraverLibrary.Models;
using GraverLibrary.Services.Common;
using Microsoft.Extensions.Configuration;
using NewGraverForms_Net.Exceptions.Serial;
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
        private const int ELEMENTS_FROM_SERIAL = 3;

        private static SerialPort SerialRangeMeter { get; set; }
        private readonly IBaseMarkerService _service;
        private readonly IConfiguration _configuration;
        private readonly IConfigurationSection _serialPortSection;
        private readonly IConfigurationSection _materialsSection;
        public MainForm(IBaseMarkerService service, IConfiguration cfg)
        {
            InitializeComponent();
            _service = service;
            _configuration = cfg;
            _serialPortSection = _configuration.GetSection("SerialRangeMeter");
            _materialsSection = _configuration.GetSection("MaterialConfiguration");
            InitArduino();
            InitComboBox();
            Log.Warning(Properties.Settings.Default.apiKey);
            Log.Warning(_configuration?.GetConnectionString("sql"));

        }

        private void InitComboBox()
        {
            var materialArray = _materialsSection.GetSection("Material").Get<Material[]>();
            comboBoxMaterial.Items.AddRange(materialArray);
            comboBoxMaterial.DisplayMember = nameof(Material.Name);
        }

        private void buttonAxisControl_Click(object sender, EventArgs e)
        {
            FormAxis form = new FormAxis(_service);
            form.Owner = this;
            form.Show();
        }


        private void button_selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "le|*.le";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                Log.Warning("Выбор файла отменён");
                return;
            }
            var pathLeFile = openFileDialog.FileName;
            Log.Information("Выбранный файл: " + pathLeFile);

            _service.SendFile(new FileStream(pathLeFile, FileMode.Open));

        }

        private void button_set_auto_height_Click(object sender, EventArgs e)
        {
            SerialRangeMeter.Open();
            int height = GetHeightToObj();
            SerialRangeMeter.Close();
            labelAutoHeight.Text = height.ToString() + " mm";
            //_service.SetHeightToObject(height);
        }

        private int GetHeightToObj()
        {
            int result = 0;
            {
                string[] rangesToObj = new string[ELEMENTS_FROM_SERIAL];
                int i = 0;
                while (i < ELEMENTS_FROM_SERIAL)
                {
                    rangesToObj[i] = SerialRangeMeter.ReadLine();
                    i++;
                }
                ValidateHeightsFromSerial(rangesToObj);
                int[] heights = new int[ELEMENTS_FROM_SERIAL];
                for (int j = 0; j < rangesToObj.Length; j++)
                {
                    string range = rangesToObj[j];
                    heights[j] = Convert.ToInt32(range);
                }
                result = (int)Math.Round(((double)heights.Sum() / ELEMENTS_FROM_SERIAL));
            }
            return result;
        }
        private void ValidateHeightsFromSerial(string[] heights)
        {
            foreach (string height in heights)
            {
                if (height.Contains("out of range"))
                {
                    throw new HeightOutOfRangeException("Object is out of range");
                }
                if (height.Contains("Failed to boot VL53L0X"))
                {
                    throw new SensorUnavailableException("Failed to boot VL53L0X");
                }
            }
        }

        private void InitArduino()
        {
            if (_serialPortSection == null)
            {
                throw new ConfigurationErrorsException("You should fill the SerialRangeMeter section of appSettings.json file!");
            }
            string portName = _serialPortSection.GetValue<string>("portName");
            int baudRate = _serialPortSection.GetValue<int>("baudRate");
            if (portName == null || baudRate == 0)
            {
                throw new ConfigurationErrorsException("Check the SerialRangeMeter section of appSettings.json file!" +
                    "\r\n The baudRate cannot be 0 and name cannot be null");
            }
            SerialRangeMeter = new SerialPort(portName: portName, baudRate: baudRate);
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(IPAddress.Parse(textBoxConnectionHost.Text));
            Debug.WriteLine(textBoxConnectionPort.Text, CultureInfo.InvariantCulture);
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
            const int COUNT_IPV4_BLOCKS = 4;
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

            const int MAX_PORT = 65535;
            if (int.Parse(((TextBox)portTextBox).Text) > MAX_PORT)
            {
                e.Handled = true;
            }
        }
    }
}
