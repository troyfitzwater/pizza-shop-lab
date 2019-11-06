using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaShop.Core
{
    public class Order
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid title")]
        public string Size { get; set; }
        public string Toppings { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
    }
}
