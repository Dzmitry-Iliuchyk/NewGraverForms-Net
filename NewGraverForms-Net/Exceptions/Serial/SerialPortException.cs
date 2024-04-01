using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGraverForms_Net.Exceptions.Serial
{
    public class SerialPortException : Exception
    {
        public SerialPortException(string? message) : base(message)
        {
        }
    }
}
