namespace NewGraverForms_Net.Exceptions.Serial
{
    public class HeightOutOfRangeException : SerialPortException
    {
        public HeightOutOfRangeException(string? message) : base(message)
        {
        }
    }
}
