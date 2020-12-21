using System.Collections.Generic;

namespace PizzaCity.Domain.Models
{
    public class Store
    {
        public List<Order> Orders {get; set;}

      //method to create order
      public void CreateOrder()
      {
        Orders.Add(new Order());
      }

      //method to read order

      //method to update order

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

       
      
    }
}