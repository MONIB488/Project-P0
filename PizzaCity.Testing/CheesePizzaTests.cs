using Xunit;
using PizzaCity.Domain.Models;
using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            //arrange
            var sut = new CheesePizza(); //inference
            CheesePizza sut1 = new CheesePizza(); //memory allocation
            

            //act
            var actual = sut;

            //assert
            Assert.IsType<CheesePizza>(actual);
            Assert.NotNull(actual);
        }

        [Fact]
        private void HasASize()
        {
            var sut = new CheesePizza();
            var actual = sut;
            Assert.IsType<CheesePizza>(actual.Size);
        }
    }
}