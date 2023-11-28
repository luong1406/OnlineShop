using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Feedback
    {
        public int Fid { get; set; }
        public int? UserId { get; set; }
        public int? Pid { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? Name { get; set; }
        public int? Star { get; set; }
        public string? Comment { get; set; }
        public string? Img { get; set; }
    }
}
