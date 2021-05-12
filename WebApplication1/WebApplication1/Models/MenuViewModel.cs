using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MenuViewModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
    }
}
