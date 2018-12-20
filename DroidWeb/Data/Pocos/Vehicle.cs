using System;
using System.Collections.Generic;
using System.Text;

namespace DroidWeb.Data.Entities
{
    public partial class Vehicle : BaseEntity
    {
        public Vehicle()
            : base()
        {
            this.Name = string.Empty;
            this.Type = string.Empty;
        }

        public Vehicle(string name, string type)
            : base()
        {
            this.Name = name;
            this.Type = type;
        }

        public override string ToString()
        {
            return $"Vehicle: Id={Id}, Name={Name}, Type={Type}";
        }
    }
}
