using Microsoft.EntityFrameworkCore;
using StoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL.EF
{
    class StoreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(local)\mssqllocaldb;Database=StoreDAL.EF.Store;Trusted_Connection=True;");
        }
    }
}
