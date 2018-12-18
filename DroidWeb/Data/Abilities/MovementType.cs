using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DroidWeb.Data.Abilities
{
    [Flags]
    public enum MovementType
    {
        None            = 0x00000000,
        Wheeled         = 0x00000001,
        Legged          = 0x00000002,
        Threaded        = 0x00000004,
        Swimming        = 0x00000008,
        Jumping         = 0x00000010,
        Flying          = 0x00000020
    }
}
