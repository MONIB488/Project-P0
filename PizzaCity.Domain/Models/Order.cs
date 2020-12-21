using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;
using PizzaCity.Domain.Factories;

namespace PizzaCity.Domain.Models
{
    public class Order
    {
      private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();
      public List<APizzaModel> Pizzas {get; set;}
      public Order()
      {
          Pizzas = new List<APizzaModel>();
      }

      public void MakeMeatPizza()
      {
          Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
      }
    }
}