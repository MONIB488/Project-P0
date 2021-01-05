using Xunit;
using PizzaCity.Domain.Models;
using PizzaCity.Domain.Abstracts;

namespace PizzaCity.Testing
{
    public class TestSize
    {
        [Fact]
        private void Test_SizeExists()
        {
            //arrange
            var sut = new Size(); //inference
            Size sut1 = new Size(); //memory allocation
            

            //act
            var actual = sut;

            //assert
            Assert.IsType<Size>(actual);
            Assert.NotNull(actual);
        }

    }
}