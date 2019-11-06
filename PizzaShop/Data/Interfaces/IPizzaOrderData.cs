using PizzaShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Data.Interfaces
{
    public interface IPizzaOrderData
    {
        IEnumerable<PizzaOrder> GetOrders();
        PizzaOrder GetOrderById(int id);
        PizzaOrder Add(PizzaOrder newOrder);
        PizzaOrder Update(PizzaOrder orderToUpdate);
    }
}
