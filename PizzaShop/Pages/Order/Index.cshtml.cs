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
        [BindProperty]
        public ShippingAddress shippingAddress { get; set; }

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

            // Stripe create charge
            var chargeOptions = new ChargeCreateOptions
            {
                Amount = pizzaOrder.Cost,
                Currency = "usd",
                Source = "tok_visa",
            };


            // Only assign shipping details to a charge object if delivery is selected
            if (pizzaOrder.IsDelivery == true)
            {
                var shippingOptions = new ChargeShippingOptions
                {
                    Name = shippingAddress.FirstName + " " + shippingAddress.LastName,
                    Address = new AddressOptions()
                    {
                        Line1 = shippingAddress.Line1,
                        City = shippingAddress.City,
                        State = shippingAddress.State,
                        PostalCode = shippingAddress.PostalCode.ToString()
                    }
                };

                chargeOptions.Shipping = shippingOptions;
            }

            var service = new ChargeService();
            TempData["OrderSize"] = pizzaOrder.Size;
            TempData["OrderQuantity"] = pizzaOrder.Quantity;
            TempData["OrderToppings"] = pizzaOrder.Toppings;
            // Divide by 100 for TempData to make the cost more viewable without bringing in any
            // JavaScript to format for us on the page. We only need the cost to be without a decimal
            // when communicating with Stripe
            TempData["OrderCost"] = pizzaOrder.Cost/100;
            if (pizzaOrder.IsDelivery == true)
            {
                TempData["OrderRetrieval"] = "Your order will arrive in 30 minutes or less!";
            }
            else
            {
                TempData["OrderRetrieval"] = "Your order will be ready for pickup in 15 minutes";
            }
            Charge charge = service.Create(chargeOptions);

            return RedirectToPage("./OrderConfirmation");
        }
    }
}