using PizzaShop.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Data.Interfaces
{
    interface IOrderData
    {
        IEnumerable<Order> GetOrders();
        Order Add(Order newOrder);
        Order Update(Order orderToUpdate);
    }
}
