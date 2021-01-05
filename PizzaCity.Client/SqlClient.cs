using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using PizzaCity.Domain.Models;
using PizzaCity.Storing;



namespace PizzaCity.Client
{
    public class SqlClient
  {
    private readonly PizzaCityContext _context = new PizzaCityContext();

    public IEnumerable<Store> ReadStores()
    {
      return _context.Stores;
    }

    public Store ReadOneStore(string name)
    {
     return _context.Stores.FirstOrDefault(s => s.Name == name);
    }

    public Customer ReadOneCustomer(string name)
    {
      return _context.Customers.FirstOrDefault(s => s.Name == name);
    }

    public IEnumerable<Customer> ReadCustomer()
    {
      return _context.Customers;
    }

    public IEnumerable<Order> ReadStoreOrders(Store store)
    {
      var s = ReadOneStore(store.Name);
      return s.Orders;
    }

    public IEnumerable<Order> ReadCustOrders(Customer customer)
    {
      return _context.Orders.Where(o => o.CustID == id);
    }

    public IEnumerable<APizzaModel> GetPizzas(Order o)
    {
      return _context.Pizzas.Where(p => p.OrderID == o.OrderID).ToList();
    }

    public Store ObtainStore(string name)
        {
            return _context.Stores.Include(store => store.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Crust).
            Include(store => store.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Size).
            Include(store => store.Orders).ThenInclude(Order => Order.Pizzas).ThenInclude(pizza => pizza.Toppings).
            FirstOrDefault(s => s.Name == name);
        }
        public Customer ObtainCustomer(string name)
        {
            return _context.Customers.Include(customer => customer.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Crust).
            Include(customer => customer.Orders).ThenInclude(order => order.Pizzas).ThenInclude(pizza => pizza.Size).
            Include(customer => customer.Orders).ThenInclude(Order => Order.Pizzas).ThenInclude(pizza => pizza.Toppings).
            FirstOrDefault(u => u.Name == name);
        }

    public void AddCustomer(Customer customer)
    {
      _context.Customers.Add(customer);
      _context.SaveChanges();
    }

    public void Save(Store store)
    {
      _context.Add(store); // git add
      _context.SaveChanges(); // git commit
    }

    public void SaveOrder(Order o)
    {
      _context.Add(store);
      _context.SaveChanges();
    }

    public Store SelectStore()
    {
      string input = Console.ReadLine();
      return ReadOneStore(input);
    }

    public void SelectCustomer(Customer customer)
    {
      string input = Console.ReadLine();
      return ReadOneCustomer(input);
    }

    public void Update()
    {
      _context.SaveChanges();
    }
  }
    
}