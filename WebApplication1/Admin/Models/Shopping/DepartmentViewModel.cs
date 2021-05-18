using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Shopping
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage ="Department Name filed is required")]
        [MaxLength(50, ErrorMessage ="Max 50 Characters")]
        public string Name { get; set; }
    }
}
