using Microsoft.EntityFrameworkCore;
using PizzaShop.Core;
using PizzaShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Data
{
    public class PizzaOrderData : IPizzaOrderData
    {
        private readonly PizzaShopContext db;

        // get context of data to track via dependency injection using 
        // what is configured for the PizzaShopContext in the Startup file
        public PizzaOrderData(PizzaShopContext context)
        {
            db = context;
        }

        // get order by id using the context if the data is being tracked within
        // the current context. otherwise, query the database
        public PizzaOrder GetOrderById(int id)
        {
            return db.PizzaOrders.Find(id);
        }

        public IEnumerable<PizzaOrder> GetOrders()
        {
            // query context for orders and order them
            // descending Id
            var query = from orders in db.PizzaOrders
                        orderby orders.Id descending
                        select orders;

            return query;
        }

        // add new order to current context to be tracked.
        // will be persisted to the databaes when SaveChanges() is called
        public PizzaOrder Add(PizzaOrder newOrder)
        {
            db.Add(newOrder);
            return newOrder;
        }

        public PizzaOrder Update(PizzaOrder orderToUpdate)
        {
            var entity = db.PizzaOrders.Attach(orderToUpdate);
            entity.State = EntityState.Modified;
            return orderToUpdate;
        }
    }
}
