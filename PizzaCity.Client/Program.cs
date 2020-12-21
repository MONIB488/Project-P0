using System;
using System.Collections.Generic;
using System.Linq;
using PizzaCity.Domain.Models;
using PizzaCity.Domain.Singletons;

namespace PizzaCity.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;
        private readonly ClientSingleton _client2;

        public Program()
        {
          _client2 = ClientSingleton.Instance;
        }

        static void Main(string[] args)
        {
          _client.MakeStore();
          Userview();  
        }

        static void PrintAllStores()
        {
            foreach(var store in _client.Stores)
            {
                System.Console.WriteLine(store);
            }
        }
 

        static void Userview()
        {
            var customer = new Customer();

            PrintAllStores();
            customer.SelectedStore = _client.SelectStore();
            customer.SelectedStore.CreateOrder();
            customer.Orders.Add(customer.SelectedStore.Orders.Last());

            //while customer.SelectPizza()
            customer.Orders.Last().MakeMeatPizza();
            customer.Orders.Last().MakeMeatPizza();

            System.Console.WriteLine(customer);
        }

    }
}
