using Xunit;
using PizzaCity.Domain.Models;

namespace PizzaCity.Testing
{
    public class OrderTests
    {
        [Fact]
        private void Test_OrderExists()
        {
            //arrange
            var sut = new Order(); //inference
            Order sut1 = new Order(); //memory allocation

            //act
            var actual = sut;

            //assert
            Assert.IsType<Order>(actual);
            Assert.NotNull(actual);
        }
    }
}