using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Question
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; } = null!;
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Answer { get; set; }
    }
}
