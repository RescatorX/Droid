using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data.Enums;

namespace DroidWeb.Data.Entities
{
    public partial class Position : BaseEntity
    {
        public Module Module { get; set; }
        public PositionProviderType Type { get; set; }
        public bool Valid { get; set; }

        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }

        public double? DeviationX { get; set; }
        public double? DeviationY { get; set; }
        public double? DeviationZ { get; set; }
    }
}
