﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DroidWeb.Data.Entities
{
    public partial class Vehicle : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
