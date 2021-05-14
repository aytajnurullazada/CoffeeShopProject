using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class ReserveTable:BaseEntity
    {
        public int Person { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
    }
}
