using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;
using System.Text;

namespace PizzaCity.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        
          public MeatPizza(Size size, Crust crust)
          {
              AddName();
              AddSize(size);
              AddCrust(crust);
              AddToppings();
              CalculatePrice();
          }

          public MeatPizza()
          {
          Name = "Three Meat Pizza";
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
          {Name = "Three Meat Pizza";}

          protected override void AddToppings()
          {
            Toppings = new List<Toppings>()
            {
                new Toppings("mozzarella"),
                new Toppings("bacon"),
                new Toppings("pepperoni"),
                new Toppings("italian sausage")
            };
          }
    }
}