using PizzaShop.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Data
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext(DbContextOptions<PizzaShopContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
