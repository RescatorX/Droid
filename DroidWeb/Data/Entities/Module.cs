using System;
using System.Collections.Generic;
using System.Text;

namespace DroidWeb.Data.Entities
{
    public partial class Module : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Version { get; set; }
    }
}
