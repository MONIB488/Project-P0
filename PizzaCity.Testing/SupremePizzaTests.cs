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
            var sut = new SupremePizza(); //inference
            SupremePizza sut1 = new SupremePizza(); //memory allocation
            

            //act
            var actual = sut;

            //assert
            Assert.IsType<SupremePizza>(actual);
            Assert.NotNull(actual);
        }

        [Fact]
        private void HasASize()
        {
            var sut = new SupremePizza();
            var actual = sut;
            Assert.IsType<SupremePizza>(actual.Size);
        }
    }
}