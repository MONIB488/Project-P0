using System;
using PizzaCity.Domain.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;


namespace PizzaCity.Domain.Singletons
{
  public class ClientSingleton
  {
      private const string _path = @"pizzacity.xml";
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

      private ClientSingleton()
      {
          Read();
      }
      
      public void MakeStore()
      {
          //var s = new Store();
          Stores.Add(new Store());
          Save();
      }

      public Store SelectStore()
      {
        int.TryParse(Console.ReadLine(), out int input);

        return Stores.ElementAtOrDefault(input);

       
      }
      private void Save()
      { 
        var file = new StreamWriter(_path);
        var xml = new XmlSerializer(typeof(List<Store>));

        xml.Serialize(file, Stores);
      }

      private void Read()
      {
        if (!File.Exists(_path))
        {
          Stores = new List<Store>();
          return;
        }
        
        var file = new StreamReader(_path);
        var xml = new XmlSerializer(typeof(List<Store>));

        Stores = xml.Deserialize(file) as List<Store>; //null if cannot convert
        //Stores = (List<Store>) xml.Deserialize(file); //exception if cannot convert
      }
  }
}