using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Core
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please select a size")]
        public string Size { get; set; }
        public string Toppings { get; set; }
        [Required(ErrorMessage = "Please select a quantity")]
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public bool IsDelivery { get; set; }
        public bool IsComplete { get; set; }
    }
}
