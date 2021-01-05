using System;
using System.Collections.Generic;
using System.Linq;
using PizzaCity.Domain.Singletons;
using PizzaCity.Domain.Models;
using PizzaCity.Domain.Singletons;
using Microsoft.EntityFrameworkCore;


namespace PizzaCity.Client
{
    class Program
    {
        private static readonly ClientSingleton _client = ClientSingleton.Instance;
        private readonly ClientSingleton _client2;
        private static readonly SqlClient _sql = new SqlClient();

        public Program()
        {
          _client2 = ClientSingleton.Instance;
        }

        static void Main(string[] args)
        {
          
          SigningInAs();  
        }

        static IEnumerable<Store> GetStores()
        {
            return _client.Stores;
        }

        static void PrintAllStoresWithEF()
        {
            foreach(var store in _sql.ReadStores())
            {
                System.Console.WriteLine(store.Name);
            }
        }
 

        static void Customerview(Customer customer)
        {
            var cust = true;
            do
            {
                System.Console.WriteLine("Do you want to view order history(1), place an order(2), or exit(3)?");
                var choose = System.Console.ReadLine();

                if (choose.Equals("1"))
                {
                    foreach (var u in customer.Orders)
                    {
                       System.Console.WriteLine(u.ToString()); 
                    }
                }

                else if (choose.Equals("2"))
                {
                    PrintAllStoresWithEF();
                    System.Console.WriteLine("Please choose a store: (type name)");

                    var ChosenStore = _sql.SelectStore();
                    List<APizzaModel> SelectedPizzas = _client.SelectPizzas();

                    ChosenStore.CreateOrder(SelectedPizzas);
                    customer.Orders.Add(ChosenStore.Orders.Last());

                    _sql.SaveOrder(customer.Orders.Last())
                    _sql.Update();

                    System.Console.WriteLine("What you have ordered so far:");
                    System.Console.WriteLine(customer.Orders.Last().ToString());
                }

                else if(choose.Equals("3"))
                {
                    cust = false;
                    System.Console.WriteLine("Thanks for stopping by!");
                }

                else
                {
                    System.Console.WriteLine("Invalid entry, try again");
                }
            }while (cust);
      
        }
        static void SigningInAs()
        {
            bool signin = true;
            do
            {
                System.Console.WriteLine("Signing in as a customer or a store or do you want to quit?");
                var info = System.Console.ReadLine();

                if(info.Equals("customer"))
                {
                    PizzaCustomer();
                }
                
                else if(info.Equals("store"))
                {
                    PizzaStore();
                } 

                else if(info.Equals("quit"))
                {
                    signin = false;
                }

                else
                {
                    System.Console.WriteLine("Invalid entry, try again");
                }

            }while(signin);

        }

        static void PizzaCustomer()
        {
            System.Console.WriteLine("New or Returning customer?");
            var info = System.Console.ReadLine();

            if(info.Equals("new"))
            {
                System.Console.WriteLine("Write your name");
                var newname = System.Console.ReadLine();
                Customer customer = new Customer(name);

                _sql.AddCustomer(customer);
                _sql.Update();
                Customerview(customer);
            }

            else if(info.Equals("returning"))
            {
                NotACust = true;
                do
                {
                    System.Console.WriteLine("Enter login name");
                    var regname = System.Console.ReadLine();

                    Customer customer = _sql.ObtainCustomer(name);
                }while (NotACust);
            }
        }

        static void PizzaStore()
        {
            System.Console.WriteLine("Which store are you checking?");
            PrintAllStoresWithEF();
            Store store = _sql.SelectStore();
            store.Orders = _sql.ReadStoreOrders(store.StoreID).ToList<Order>();
            double total = 0;

            foreach(Order o in store.Orders)
            {
                System.Console.WriteLine(o.ToString());
                total = total + o.TotalPrice;
            }

            System.Console.WriteLine("The total price is ${total}");
        }

    }
}
