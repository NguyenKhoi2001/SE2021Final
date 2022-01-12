using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCheckTheGood.Models
{
    public class OrderList
    {
        public string Pid { get; set; }
        public string PName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Total { get { return Quantity * Price; } }
    }
}