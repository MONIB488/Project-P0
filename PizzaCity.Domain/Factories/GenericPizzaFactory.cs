using PizzaCity.Domain.Abstracts;

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