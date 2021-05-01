using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
  public  class ProductReview : BaseEntity
    {
        public int ProductId { get; set; }
        [Required]
        public byte Star { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Review { get; set; }
        public Product Product { get; set; }
    }
}
