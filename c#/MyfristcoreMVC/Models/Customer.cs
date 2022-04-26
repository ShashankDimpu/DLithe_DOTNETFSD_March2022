using System;
using System.Collections.Generic;

namespace MyfristcoreMVC.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Address { get; set; }
        public decimal? Salary { get; set; }
    }
}
