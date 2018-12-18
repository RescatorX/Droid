using System;
using System.Collections.Generic;
using System.Text;

namespace DroidWeb.Data.Entities
{
    public class Vehicle : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }

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
