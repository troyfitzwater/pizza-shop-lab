using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Core;
using PizzaShop.Data;

namespace PizzaShop.Pages.Order
{
    public class IndexModel : PageModel
    {
        private readonly PizzaShopContext _context;

        [BindProperty]
        public PizzaOrder pizzaOrder { get; set; }

        public IndexModel(PizzaShopContext context)
        {
            _context = context;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Pizza builder 
            if(!ModelState.IsValid)
            {
                return Page();
            }

            pizzaOrder.IsComplete = false;

            _context.PizzaOrders.Add(pizzaOrder);
            await _context.SaveChangesAsync();

            // Stripe create charge & customer

            return RedirectToPage("../Index");
        }
    }
}