using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Order
    {
        public int UserID { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int OrderID { get; set; }

        public DateTime Date { get; set; }

        public string Licenseplatenumber { get; set; }

        public int Km { get; set; }
    }
}
