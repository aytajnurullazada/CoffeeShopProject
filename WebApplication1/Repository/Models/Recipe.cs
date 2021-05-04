using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Recipe:BaseEntity
    {
        public int DepartmentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Image { get; set; }
        public int OrderBy { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}
