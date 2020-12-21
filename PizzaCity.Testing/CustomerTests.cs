using Xunit;
using PizzaCity.Domain.Models;

namespace PizzaCity.Testing
{
    public class CustomerTests
    {
        [Fact]
        private void Test_CustomerExists()
        {
            //arrange
            var sut = new Customer(); //inference
            Customer sut1 = new Customer(); //memory allocation

            //act
            var actual = sut;

            //assert
            Assert.IsType<Customer>(actual);
            Assert.NotNull(actual);
        }
    }
}