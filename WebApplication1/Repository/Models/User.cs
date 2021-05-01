using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class User:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string AddInform { get; set; }
        [MaxLength(100)]
        public string Token { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<Favorites> Favorites { get; set; }


    }
}
