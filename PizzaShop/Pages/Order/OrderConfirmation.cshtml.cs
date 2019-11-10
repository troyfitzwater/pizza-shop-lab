using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaShop.Pages.Order
{
    public class OrderConfirmationModel : PageModel
    {
        [TempData]
        public string OrderSize { get; set; }
        [TempData]
        public int OrderQuantity { get; set; }
        [TempData]
        public string OrderToppings { get; set; }
        [TempData]
        public int OrderCost { get; set; }
        [TempData]
        public string OrderRetrieval { get; set; }

        public void OnGet()
        {

        }
    }
}