using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using DroidWeb.Data.Entities;

namespace DroidWeb.Areas.System.Models
{
    public class HardwareModel
    {
        [Key]
        public Guid Id { get; set; }

        public List<Module> Modules { get; set; }
    }
}
