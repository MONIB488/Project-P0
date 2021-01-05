using System.Collections.Generic;
using PizzaCity.Domain;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PizzaCity.Domain.Abstracts
{
    public class APizzaModel 
    {
        public ICollection<Toppings> Toppings {get; set;}
        public Crust crust {get; set;}
        public Size size {get; set;}
        public double Price {get; set;}
        public string Name {get; set;}
        public long PizzaID {get; set;}
        public long OrderID {get; set;}
        

        public override string ToString()
        {
            CalculatePrice();
            var str = new StringBuilder();
            foreach (var top in Toppings)
            {
              str.AppendLine(top.Name);  
            }

            return $"You have ordered a {Size.Name} {Name} with {Crust.Name} for ${Price}: {str.ToString()}";
        }

         public virtual void CalculatePrice()
        {
            Price = Crust.Price + Size.Price;
        }

        protected virtual void AddCrust(){}
        protected virtual void AddSize(){}
        protected virtual void AddToppings(){}
        protected virtual void AddName(){}
        protected virtual void SetPrice(){}
    }

   
}