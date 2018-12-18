using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DroidWeb.Utils.Helpers
{
    public static class ConverterHelper
    {
        public static string DoubleToAngle(this IHtmlHelper htmlHelper, double? axis)
        {
            double locAxis = axis.HasValue ? axis.Value : 0.0;
            int degrees = Convert.ToInt16(locAxis);
            int minutes = Convert.ToInt16(Math.Floor((locAxis - degrees) * 60));
            double seconds = Convert.ToDouble((locAxis - degrees - ((double)minutes / 60.0)) * 3600);
            return $"{degrees:00}° {minutes:00}' {seconds:00.000}''";
        }
    }
}
