using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Core;
using PizzaShop.Data;
using Stripe;

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

            var shippingOptions = new ChargeShippingOptions
            {
                Name = "Troy Test Pizza",
                Address = new AddressOptions()
                {
                    Line1 = "line1",
                    City = "Bath",
                    State = "NY",
                    PostalCode = "14810"
                }
            };

            var chargeOptions = new ChargeCreateOptions
            {
                Amount = pizzaOrder.Cost,
                Currency = "usd",
                Description = "Example charge",
                Source = "tok_visa",
                Shipping = shippingOptions
            };

            //var customerService = new CustomerService();
            //customerService.Create(customerOptions);

            var service = new ChargeService();
            TempData["OrderInfoName"] = shippingOptions.Address.Line1;
            Charge charge = service.Create(chargeOptions);

            return RedirectToPage("./OrderConfirmation");
        }
    }
}