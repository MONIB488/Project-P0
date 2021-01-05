using System;
using PizzaCity.Domain.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;
using PizzaCity.Domain.Abstracts;


namespace PizzaCity.Domain.Singletons
{
  public class ClientSingleton
  {
      private static ClientSingleton _instance;
      public static ClientSingleton Instance
      {
        get
        {
            if(_instance == null)
            {
                _instance = new ClientSingleton();
            }

            return _instance;
        }
      }

      public List<Store> Stores {get; set;}
      public List<APizzaModel> Pizzas {get; set;}

      private ClientSingleton()
      {
          Stores = new List<Store>();
      }

      public Store SelectStore()
      {
        int.TryParse(Console.ReadLine(), out int input);

        return Stores.ElementAtOrDefault(input); 
      }
      public void PrintPizzas()
      {
        var cheese = new CheesePizza();
        var three = new MeatPizza();
        var sup = new SupremePizza();

        System.Console.WriteLine("Pizza Options:");
        System.Console.WriteLine("1." + (cheese.Name));
        System.Console.WriteLine("2." + (three.Name));
        System.Console.WriteLine("3." + (sup.Name));
      }

      public List<APizzaModel> PickAPizza()
      {
        bool Exit = true;
        List<APizzaModel> Pizzas = new List<APizzaModel>();
        GenericPizzaFactory _generic = new GenericPizzaFactory();

        do
        {
          System.Console.WriteLine("Please choose your pizza. Type 0 when done");
          PrintPizzas();
          int.TryParse(Console.ReadLine(), out int input);
          switch(input)
          {
             case 1:
             {
               var size = ChooseSize();
               var crust = ChooseCrust();
               var pizza = new CheesePizza(size,crust);
               Pizzas.Add(pizza);
               break;
             }

             case 2:
             {
               var size = ChooseSize();
               var crust = ChooseCrust();
               var pizza = new MeatPizza(size,crust);
               Pizzas.Add(pizza);
               break;
             }

             case 3:
             {
               var size = ChooseSize();
               var crust = ChooseCrust();
               var pizza = new SupremePizza(size,crust);
               Pizzas.Add(pizza);
               break;
             }

             case 0:
             {Exit = false; break;}

             default:
             {
               System.Console.WriteLine("Invalid entry, try again");
               break;
             }
          }
        }while (Exit);
        return Pizzas;
      }

      public Crust ChooseCrust()
      {
        while (true)
        {
          System.Console.WriteLine("Choose your crust: 1. Regular   2.Garlic Butter  3.Cheese Stuffed");
          int.TryParse(Console.ReadLine(), out int input);
          switch(input)
          {
             case 1:
             {
               Crust crust = new Crust("Regular");
               return crust;
             }

             case 2:
             {
               Crust crust = new Crust("Garlic Butter");
               return crust;
             }

             case 3:
             {
               Crust crust = new Crust("Cheese Stuffed");
               return crust;
             }

             default:
             {
               System.Console.WriteLine("Invalid entry, try again");
               break;
             }   
          }
        }
      }

      public Size ChooseSize()
      {
        while (true)
        {
          System.Console.WriteLine("Choose a size: 1. small  2. medium  3. large");
          int.TryParse(Console.ReadLine(), out int input);
          switch (input)
          {
              
            case 1:
            {
              Size size = new Size("small");
              return size;
            }

            case 2:
            {
              Size size = new Size("medium");
              return size;
            }

            case 3:
            {
              Size size = new Size("large");
              return size;
            }

            default: 
            {
              System.Console.WriteLine("Invalid entry, try again");
              break;
            }
          }
        }
      }


  }
}