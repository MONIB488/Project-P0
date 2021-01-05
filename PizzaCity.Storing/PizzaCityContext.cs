using Microsoft.EntityFrameworkCore;
using PizzaCity.Domain.Abstracts;
using PizzaCity.Domain.Models;
using System.Collections.Generic;


namespace PizzaCity.Storing
{
    public class PizzaCityContext : DbContext
    {
        public DbSet<Store> Stores {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Size> Sizes {get; set;}
        public DbSet<Crust> Crusts {get; set;}
        public DbSet<Order> Orders {get; set;}
        public DbSet<APizzaModel> Pizzas {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:monicapizzacity.database.windows.net;Initial Catalog=PizzaCity;User ID=sqladmin;Password={katsuki8991*};");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Store>().HasKey(s => s.StoreID);
            builder.Entity<Customer>().HasKey(c => c.CustID);
            builder.Entity<Customer>()
                .Property(u => u.Name)
                .HasColumnName("Customer Name")
                .IsRequired();
            builder.Entity<Order>().HasKey(o => o.OrderID);
            builder.Entity<APizzaModel>().HasKey(p => p.PizzaID);
            builder.Entity<APizzaModel>().OwnsOne(p => p.Size);
            builder.Entity<APizzaModel>().OwnsOne(p => p.Crust);
            builder.Entity<APizzaModel>().OwnsMany(p => p.Toppings);

            SeedData(builder);
        }

        protected void SeedData(ModelBuilder builder)
        {
            builder.Entity<Store>().HasData(new List<Store>
            {
                new Store() {Name = "Pizza City", StoreID = AnEntity()},
                new Store() {Name = "Pizza City 2", StoreID = AnEntity()}
            }    
            );

            builder.Entity<Customer>().HasData(new List<Customer>
            {
                new Customer(){Name = "Monica B", CustID = AnEntity()}
            }
            );
        }
    }
}