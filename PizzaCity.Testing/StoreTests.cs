using Xunit;
using PizzaCity.Domain.Models;

namespace PizzaCity.Testing
{
    public class StoreTests
    {
        [Fact]
        private void Test_StoreExists()
        {
            //arrange
            var sut = new Store(); //inference
            Store sut1 = new Store(); //memory allocation

            //act
            var actual = sut;

            //assert
            Assert.IsType<Store>(actual);
            Assert.NotNull(actual);
        }
    }
}