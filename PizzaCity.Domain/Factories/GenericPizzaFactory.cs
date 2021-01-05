using PizzaCity.Domain.Abstracts;
using System.Collections.Generic;

namespace PizzaCity.Domain.Factories
{
    class GenericPizzaFactory
    {
        public T Make<T>() where T : APizzaModel, new()
        {
            return new T();
        }
    }
}