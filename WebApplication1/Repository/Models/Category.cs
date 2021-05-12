using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Category: BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Menu> Menu { get; set; }
    }
}
