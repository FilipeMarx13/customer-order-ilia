using customer_order_ilia.Domain.Entities;
using Xunit;

namespace customer_order_ilia.Tests.Domain.Entities
{
    public class OrderTest
    {
        [Fact]
        public void IfBuildObject_WhenInformedData_SoThenValidateMapping()
        {
            //Arrange
            Customer customer = new Customer("John Mayer", "email@test.com");
            var quantity = 3;
            Product product = new Product("Orange Juice", 5, quantity);

            //Act
            var order = new Order(customer, product, quantity);

            //Assert
            Assert.Equal(customer.Name, order.Customer.Name);
            Assert.Equal(customer.Email, order.Customer.Email);
            Assert.Equal(product.Description, order.Product.Description);
            Assert.Equal(product.Price, order.Product.Price);
        }
    }
}
