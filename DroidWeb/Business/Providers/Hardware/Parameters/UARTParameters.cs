using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroidWeb.Business.Providers.Hardware.Parameters
{
    public enum BaudRate
    {
        B300, B600, B1200, B1800, B2400, B4800, B7200, B9600, B14400, B19200, B28800, B38400, B51200, B57600, B76800, B115200, B153600, B230400, B460800, B576000
    }

    public enum DataBits
    {
        D5, D6, D7, D8
    }

    public enum StopBits
    {
        S1, S15, S2
    }

    public enum ParityType
    {
        None, Even, Odd, Mark, Space
    }

    public class UARTParameters : IParameters
    {
        public string Port { get; set; }
        public BaudRate BaudRate { get; set; }
        public DataBits DataBits { get; set; }
        public StopBits StopBits { get; set; }
        public ParityType Parity { get; set; }
    }
}
