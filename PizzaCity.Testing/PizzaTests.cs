using Xunit;
using PizzaCity.Domain.Models;

namespace PizzaCity.Testing
{
    public class PizzaTests
    {
        [Fact]
        private void Test_PizzaExists()
        {
            //arrange
            var sut = new MeatPizza(); //inference
            MeatPizza sut1 = new MeatPizza(); //memory allocation

            //act
            var actual = sut;

            //assert
            Assert.IsType<MeatPizza>(actual);
            Assert.NotNull(actual);
        }
    }
}