using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DroidWeb.Data.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        internal BaseEntity()
        {
            this.Id = Guid.NewGuid();
        }

        public abstract override string ToString();
    }
}
