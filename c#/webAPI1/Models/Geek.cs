using System;
using System.Collections.Generic;

namespace webAPI1.Models
{
    public partial class Geek
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Location { get; set; }
    }
}
