using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;
using System.ComponentModel.DataAnnotations;

namespace PizzaCity.Domain.Models
{
    public class Store : APizzaModel
    {
        public string Name {get; set;}
        public List<Order> Orders {get; set;}
        public long StoreID {get; set;}

        public Store()
        {
            Orders = new List<Order>();
        }

      //method to create order
      public void CreateOrder(List<APizzaModel> Pizzas)
      {
        Orders.Add(new Order(Pizzas));
      }

      //method to delete order
      bool DeleteOrder(Order order)
      {
          try
          {
              Orders.Remove(order);

              return true;
          }

          catch
          {
              return false;
          }
      }

        public override string ToString()
        {
            return $"{Name}";
        }




      

       
      
    }
}