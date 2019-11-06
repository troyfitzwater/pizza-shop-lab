using PizzaShop.Core;
using PizzaShop.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace PizzaShop.Data
{
    public class OrderData : IOrderData
    {
        public IEnumerable<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public Order Add(Order newOrder)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order orderToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
