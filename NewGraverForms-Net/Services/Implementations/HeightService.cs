using Microsoft.Extensions.Configuration;
using NewGraverForms_Net.Exceptions.Serial;
using NewGraverForms_Net.Models;
using NewGraverForms_Net.Services.Common;
using System.Configuration;
using System.IO.Ports;

namespace NewGraverForms_Net.Services.Implementations
{
    public class HeightService : IHeightService
    {
        private SerialPort _serialRangeMeter;
        private readonly SerialConfig _config;
        private const int ELEMENTS_FROM_SERIAL = 3;

        public HeightService(SerialConfig config)
        {
            _config = config;
            Init();
        }

        public int GetHeightToObj()
        {
            try
            {
                _serialRangeMeter.Open();
            }
            catch (IOException ioEx)
            {
                throw new SerialPortException(ioEx.Message);
            }
            int result = 0;
            {
                string[] rangesToObj = new string[ELEMENTS_FROM_SERIAL];
                int i = 0;
                while (i < ELEMENTS_FROM_SERIAL)
                {
                    rangesToObj[i] = _serialRangeMeter.ReadLine();
                    i++;
                }
                ValidateHeightsFromSerial(rangesToObj);
                int[] heights = new int[ELEMENTS_FROM_SERIAL];
                for (int j = 0; j < rangesToObj.Length; j++)
                {
                    string range = rangesToObj[j];
                    heights[j] = Convert.ToInt32(range);
                }
                result = (int)Math.Round((double)heights.Sum() / ELEMENTS_FROM_SERIAL);
            }
            _serialRangeMeter.Close();
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

        private void Init()
        {
            if (_config == null)
            {
                throw new ConfigurationErrorsException("You should fill the SerialRangeMeter section of appSettings.json file!");
            }
            string portName = _config.PortName;
            int baudRate = _config.BaudRate;
            if (portName == null || baudRate == 0)
            {
                throw new ConfigurationErrorsException("Check the SerialRangeMeter section of appSettings.json file!" +
                    "\r\n The baudRate cannot be 0 and name cannot be null");
            }
            _serialRangeMeter = new SerialPort(portName: portName, baudRate: baudRate);
        }

    }
}
