using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroidWeb.Data.Abilities
{
    [Flags]
    public enum CommunicationType
    {
        None                = 0x00000000,
        Wired               = 0x00001000,
        RS232               = Wired & 0x00000001,
        I2C                 = Wired & 0x00000002,
        SPI                 = Wired & 0x00000004,
        CAN                 = Wired & 0x00000008,
        ProfiBus            = Wired & 0x00000010,
        Aerial              = 0x00002000,
        GSM                 = Aerial & 0x00000020,
        Wifi                = Aerial & 0x00000040,
        BlueTooth           = Aerial & 0x00000080,
        Radio               = Aerial & 0x00000100,
        Optical             = 0x00004000,
        Irda                = Optical & 0x00000200,
        Laser               = Optical & 0x00000400,
    }
}
