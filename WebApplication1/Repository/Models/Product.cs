using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Product : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        public byte StarCount { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductPhoto> Photo { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<Favorites> favorites { get; set; }
    }
}
