using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;
using PizzaCity.Domain.Factories;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaCity.Domain.Models
{
    public class Order
    {
      private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();
      public List<APizzaModel> Pizzas {get; set;}
      public long OrderID{get; set;}
      public long StoreID{get; set;}
      public long CustID{get; set;}

      public double TotalPrice
      {
          get{CalculatePrice;} set{CalculatePrice;}
      }
      
      public Order()
      {
          Pizzas = new List<APizzaModel>();
      }

      public void MakeMeatPizza()
      {
          Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
      }

      public void MakeCheesePizza()
      {
          Pizzas.Add(_pizzaFactory.Make<CheesePizza>());
      }

      public void MakeSupremePizza()
      {
          Pizzas.Add(_pizzaFactory.Make<SupremePizza>());
      }

      public override string ToString()
      {
          StringBuilder sb = new StringBuilder();
          sb.AppendLine("These are the pizzas you ordered:");
          foreach (var p in Pizzas)
          {
              sb.AppendLine(p.ToString());
          }

          sb.AppendLine($"Your total price is: {TotalPrice}");
          return sb.ToString();
      }

      public double CalculatePrice()
      {
          double compute = 0;
          foreach (APizzaModel pizza in Pizzas)
          {compute = compute + pizza.Price;}

          return compute;
      }
      

    }
}