using Xunit;
using PizzaCity.Domain.Models;
using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Testing
{
    public class TestToppings
    {
        [Fact]
        private void Test_ToppingsExists()
        {
            //arrange
            var sut = new Toppings(); //inference
            Toppings sut1 = new Toppings(); //memory allocation
            

            //act
            var actual = sut;

            //assert
            Assert.IsType<Toppings>(actual);
            Assert.NotNull(actual);
        }

        [Fact]
        private void HasToppingData()
        {
            var sut = new Toppings();
            var actual = sut;
            Assert.IsType<Toppings>(actual.Name);
        }
    }
}