using Microsoft.EntityFrameworkCore;
using PizzaShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Data
{
    public class PizzaShopContext : DbContext
    {
        // Context to act as a local instance of data pertaining to the pizz shop.
        // Implementation of the repository and unit of work patterns
        public PizzaShopContext(DbContextOptions<PizzaShopContext> options) : base(options)
        {

        }

        public DbSet<PizzaOrder> PizzaOrders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
