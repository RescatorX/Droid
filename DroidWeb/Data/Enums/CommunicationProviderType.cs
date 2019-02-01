using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroidWeb.Data.Enums
{
    public enum CommunicationProviderType
    {
        Unknown,
        UART,
        OneWire,
        I2C,
        SPI,
        CAN,
        GSM,
        Radio,
        Wifi,
        Bluetooth,
        Optical
    }
}
