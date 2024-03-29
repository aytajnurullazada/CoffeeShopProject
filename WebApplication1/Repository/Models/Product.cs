﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Product : BaseEntity
    {

        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public int Count { get; set; }
        public byte StarCount { get; set; }
        public Department Department { get; set; }
        public string Image { get; set; }
        

    }
}
