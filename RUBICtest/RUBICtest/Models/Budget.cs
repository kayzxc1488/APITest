using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RUBICtest.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Lable_percentage { get => (Percentage * 100).ToString() + "%"; }
        public float Percentage { get; set; }
        public string Color { get; set; }
    }
}
