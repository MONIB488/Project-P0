using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Domain.Models
{
    public class Crust
    {
        public double Price {get; set;}
        public string Name { get; set;}
        public Crust()
        {

        }
        public Crust(string name)
        {
            if(Name.Equals("Regular"))
            {Price = 4;}

            else if(Name.Equals("Garlic Butter"))
            {Price = 5.75;}

            else if(Name.Equals("Cheese Stuffed"))
            {Price = 9;}
        }
    }
}