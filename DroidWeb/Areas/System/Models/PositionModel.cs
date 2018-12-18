using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data.Entities;

namespace DroidWeb.Areas.System.Models
{
    public class PositionModel
    {
        [Key]
        public Guid Id { get; set; }

        public List<Position> AcquiredPositions { get; set; }
        public Position PrecisePosition { get; set; }
    }
}
