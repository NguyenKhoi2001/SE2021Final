using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CheckTheGoodApp
{
    public class Receipt
    {
        public string Id { get; set; }
        public string PName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int total { get { return Price * Quantity; } }

    }
}
