using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Domain.Models
{
    public class Toppings
    {
        public string Name {get; set;}

        public Toppings()
        {Name = "";}
        
        public Toppings(string name)
        {Name =name;}
    }
}
