using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroidWeb.Data.Abilities
{
    [Flags]
    public enum PoweringType
    {
        None            = 0x00000000,
        Powered         = 0x00001000,
        Powering        = 0x00002000,
        Charging        = 0x00004000,
        Battery         = Powering & Charging & 0x00000010,
        Dynamo          = Powering & 0x00000020,
        Nuclear         = Powering & 0x00000040,
        Combusion       = Powering & 0x00000080,
        Solar           = Powering & 0x00000100,
    }
}
