using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaShop.Core;
using PizzaShop.Data;
using PizzaShop.Data.Interfaces;

namespace PizzaShop.Pages.Admin
{
    public class OrdersModel : PageModel
    {
        private readonly PizzaShopContext _context;
        private readonly IPizzaOrderData pizzaOrderData;

        public OrdersModel(PizzaShopContext context, IPizzaOrderData pizzaOrderData)
        {
            _context = context;
            this.pizzaOrderData = pizzaOrderData;
        }

        // IList of type PizzaOrder
        // aka, an enumerable list of items that are of type PizzaOrder.
        // these can be rendered to when the page renders.
        public IList<PizzaOrder> PizzaOrders { get; set; }

        [BindProperty]
        public PizzaOrder pizzaOrder { get; set; }

        // Task represents an asynchronous action itself, not its result
        public async Task OnGetAsync()
        {
            // async needs to return an await
            PizzaOrders = await _context.PizzaOrders.ToListAsync();
        }

        public IActionResult OnPost(int orderId)
        {
            pizzaOrder = pizzaOrderData.GetOrderById(orderId);

            if (pizzaOrder != null)
            {
                pizzaOrder.IsComplete = true;
            }

            pizzaOrderData.Update(pizzaOrder);
            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}