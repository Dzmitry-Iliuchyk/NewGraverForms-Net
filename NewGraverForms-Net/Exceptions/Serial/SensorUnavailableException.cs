namespace NewGraverForms_Net.Exceptions.Serial
{
    public class SensorUnavailableException : SerialPortException
    {
        public SensorUnavailableException(string? message) : base(message)
        {
        }
    }
}
