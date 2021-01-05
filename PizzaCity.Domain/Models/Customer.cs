using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Domain.Models
{
    public class Customer
    {
      public List<Order> Orders {get; set;}
      public long CustID {get; set;}
      public string Name {get; set;}
      

      public Customer()
      {
          Orders = new List<Order>();
          Name = "";
      }

        public Customer(string name)
        {
            Orders = new List<Order>();
            Name = name;
        }
    }
}