using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Account
    {
        public int UId { get; set; }
        public string? User { get; set; }
        public string? Pass { get; set; }
        public int? IsSell { get; set; }
        public int? IsAdmin { get; set; }
    }
}
