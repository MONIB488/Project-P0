using Xunit;
using PizzaCity.Domain.Models;
using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Testing
{
    public class CrustTesting
    {
        [Fact]
        private void Test_CrustExists()
        {
            //arrange
            var sut = new Crust(); //inference
            Crust sut1 = new Crust(); //memory allocation
            

            //act
            var actual = sut;

            //assert
            Assert.IsType<Crust>(actual);
            Assert.NotNull(actual);
        }

        [Fact]
        private void HasAPrice()
        {
            var sut = new Crust();
            var actual = sut;
            Assert.IsType<double>(actual.Price);
            Assert.NotNull(actual.ToString());
        }
    }
}