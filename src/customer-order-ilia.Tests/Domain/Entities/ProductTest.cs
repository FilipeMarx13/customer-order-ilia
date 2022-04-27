using customer_order_ilia.Domain.Entities;
using Xunit;

namespace customer_order_ilia.Tests.Domain.Entities
{
    public class ProductTest
    {
        [Fact]
        public void IfBuildObject_WhenInformedData_SoThenValidateMapping()
        {
            //Arrange
            var quantity = 3;
            var description = "Orange Juice";
            decimal price = 5;

            //Act
            Product product = new Product(description, price, quantity);

            //Assert
            Assert.Equal(description, product.Description);
            Assert.Equal(price, product.Price);
            Assert.Equal(quantity, product.Quantity);
        }
    }
}
