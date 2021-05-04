using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Department: BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
    }
}
