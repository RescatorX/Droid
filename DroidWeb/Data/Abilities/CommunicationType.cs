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
        CAN                 = Wired & 0x00000004,
        ProfiBus            = Wired & 0x00000008,
        Aerial              = 0x00002000,
        GSM                 = Aerial & 0x00000010,
        Wifi                = Aerial & 0x00000020,
        BlueTooth           = Aerial & 0x00000040,
        Radio               = Aerial & 0x00000040,
        Optical             = 0x00004000,
        Irda                = Optical & 0x00000100,
        Laser               = Optical & 0x00000200,
    }
}
