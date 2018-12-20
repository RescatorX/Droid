
using System;
using System.Collections.Generic;
using System.Text;

namespace DroidWeb.Data.Entities
{
    public partial class Module : BaseEntity
    {
        public Module()
            : base()
        {
            this.Name = string.Empty;
            this.Type = string.Empty;
            this.Brand = string.Empty;
            this.Version = string.Empty;
        }

        public Module(string name = null, string type = null, string brand = null, string version = null)
            : base()
        {
            this.Name = name;
            this.Type = type;
            this.Brand = brand;
            this.Version = version;
        }

        public override string ToString()
        {
            return $"HWModule: Id={Id}, Name={Name}, Type={Type}, Brand={Brand}, Version={Version}";
        }
    }
}
