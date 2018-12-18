﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data.Enums;

namespace DroidWeb.Data.Entities
{
    public class Position : BaseEntity
    {
        public HWModule Module { get; set; }
        public PositionProviderType Type { get; set; }
        public bool Valid { get; set; }

        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Z { get; set; }

        public double? DeviationX { get; set; }
        public double? DeviationY { get; set; }
        public double? DeviationZ { get; set; }

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

        public Position(HWModule module, PositionProviderType type, bool valid = true, double? x = null, double? y = null, double? z = null, double? deviationx = null, double? deviationy = null, double? deviationz = null)
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
