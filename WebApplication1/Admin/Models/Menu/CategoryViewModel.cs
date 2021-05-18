using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Menu
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Category Name filed is required")]
        [MaxLength(50, ErrorMessage = "Max 50 Characters")]
        public string Name { get; set; }
    }
}
