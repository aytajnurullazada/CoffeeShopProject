using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class ReserveForm:BaseEntity
    {
        public string FullName { get; set; }
        public int Number { get; set; }
        public int StateNum { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Email { get; set; }
    }
}
