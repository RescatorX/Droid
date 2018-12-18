using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data.Entities;

namespace DroidWeb.Utils.Extensions
{
    public static class PositionExtension
    {
        public static Position GetPrecisePosition(this IEnumerable<Position> positions)
        {
            return positions
                .Where(p => p.Valid)
                .OrderBy(p => 
                        (Math.Sqrt(
                        (p.DeviationX.HasValue ? Math.Pow(p.DeviationX.Value, 2) : 0) +
                        (p.DeviationY.HasValue ? Math.Pow(p.DeviationY.Value, 2) : 0) +
                        (p.DeviationZ.HasValue ? Math.Pow(p.DeviationZ.Value, 2) : 0)
                        )))
                .First();
        }
    }
}
