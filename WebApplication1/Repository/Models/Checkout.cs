using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Checkout:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(50)]
        public int Number { get; set; }
        [Required]
        [MaxLength(100)]
        public string OwnAdress { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string AddInfo { get; set; }
        public Basket Basket { get; set; }
    }
}
