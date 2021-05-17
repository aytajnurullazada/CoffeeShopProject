using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Decimal Price { get; set; }
        public string Image { get; set; }
        public byte StarCount { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int DepartmentId { get; set; }
        public BasketViewModel Basket { get; set; }
        public int BasketCount { get; set; }

    }
}
