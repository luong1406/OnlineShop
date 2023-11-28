using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? CusId { get; set; }
        public int? Totalmoney { get; set; }
    }
}
