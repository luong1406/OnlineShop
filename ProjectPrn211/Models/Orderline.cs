using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Orderline
    {
        public int Oid { get; set; }
        public int Pid { get; set; }
        public double? Quantity { get; set; }
        public double? Price { get; set; }
    }
}
