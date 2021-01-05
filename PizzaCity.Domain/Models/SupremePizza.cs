using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;
using System.Text;

namespace PizzaCity.Domain.Models
{
    public class SupremePizza : APizzaModel
    {
          public SupremePizza(Size size, Crust crust)
          {
              AddName();
              AddSize(size);
              AddCrust(crust);
              AddToppings();
              CalculatePrice();
          }

          public SupremePizza()
          {
            Name = "Supreme Pizza";
            Crust = crust;
            Size = size;
            Toppings = new List<Toppings>();
          }

          public void AddCrust(Crust crust)
          {
            Crust = crust;
          }

          public void AddSize(Size size)
          {
            Size = size;    
          }

          protected override void AddName()
          {Name = "Supreme Pizza";}

          protected override void AddToppings()
          {
            Toppings = new List<Toppings>()
            {
                new Toppings("mozzarella"),
                new Toppings("black olives"),
                new Toppings("green peppers"),
                new Toppings("onions")
            };
          }
    }
}