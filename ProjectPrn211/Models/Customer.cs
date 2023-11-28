using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Phone { get; set; }
        public string? Address { get; set; }
    }
}
