using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data.Enums;

namespace DroidWeb.Data.Entities
{
    public partial class Position : BaseEntity
    {
        public Position()
            : base()
        {
            this.Module = null;
            this.Type = PositionProviderType.Unknown;
            this.Valid = false;

            this.X = null;
            this.Y = null;
            this.Z = null;

            this.DeviationX = null;
            this.DeviationY = null;
            this.DeviationZ = null;
        }

        public Position(Module module, PositionProviderType type, bool valid = true, double? x = null, double? y = null, double? z = null, double? deviationx = null, double? deviationy = null, double? deviationz = null)
            : base()
        {
            this.Module = module;
            this.Type = type;
            this.Valid = valid;

            this.X = x;
            this.Y = y;
            this.Z = z;

            this.DeviationX = deviationx;
            this.DeviationY = deviationy;
            this.DeviationZ = deviationz;
        }

        public override string ToString()
        {
            return $"Position: Id={Id}, Module={Module}, Type={Type}, valid={Valid}, X={X}, Y={Y}, Z={Z}, DeviationX={DeviationX}, DeviationY={DeviationY}, Z={DeviationZ},";
        }
    }
}
