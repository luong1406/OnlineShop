using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? CateId { get; set; }
        public int? SellId { get; set; }
    }
}
