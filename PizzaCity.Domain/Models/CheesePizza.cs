using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;
using System.Text;

namespace PizzaCity.Domain.Models
{
    public class CheesePizza : APizzaModel
    {
          public CheesePizza(Size size, Crust crust)
          {
              AddName();
              AddSize(size);
              AddCrust(crust);
              AddToppings();
              CalculatePrice();
          }

          public CheesePizza()
          {
          Name = "Three Cheese Pizza";
          Crust = new Crust();
          Size = new Size();
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
          {Name = "Three Cheese Pizza";}

          protected override void AddToppings()
          {
            Toppings = new List<Toppings>()
            {
                new Toppings("parmesan cheese"),
                new Toppings("sharp cheddar"),
                new Toppings("mozzarella")
            };
          }
    }
}