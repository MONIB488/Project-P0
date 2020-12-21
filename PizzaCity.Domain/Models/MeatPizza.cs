using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Domain.Models
{
    public class MeatPizza : APizzaModel
    {
        protected override void AddCrust()
        {
            Crust = "regular";
            Crust = "Garlic Butter";
            Crust = "Cheese Stuffed";
        }

        protected override void AddSize()
        {
            Size = "small";
            Size = "medium";
            Size = "large";
        }

        protected override void AddToppings()
        {
            Toppings = new List<string>
            {
                "cheese",
                "roma tomato",
                "pepperoni",
                "italian sausage",
                "beef sausage",
                "spinach",
                "onions",
                "peppers",
                "olives"
            };
        }
    }
}