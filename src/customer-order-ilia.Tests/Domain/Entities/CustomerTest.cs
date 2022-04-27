using customer_order_ilia.Domain.Entities;
using Xunit;

namespace customer_order_ilia.Tests.Domain.Entities
{
    public class CustomerTest
    {
        [Fact]
        public void IfBuildObject_WhenInformedData_SoThenValidateMapping()
        {
            //Arrange
            var name = "Name Test";
            var email = "Email@Test.com";
            //Act
            var customer = new Customer(name, email);

            //Assert
            Assert.Equal(name, customer.Name);
            Assert.Equal(email, customer.Email);
        }
    }
}
