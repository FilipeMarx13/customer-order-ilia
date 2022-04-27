using System;
using customer_order_ilia.Application.Interface;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Repositories;
using customer_order_ilia.Domain.Service;
using customer_order_ilia.Infrastructure.Repositories;
using Moq;
using Xunit;

namespace customer_order_ilia.Tests.Domain.Service
{
    public class CustomerServiceTest
    {
        private Mock<ICustomerRepository> _customerRepositoryMock;
        private Mock<ICustomerReadRepository> _customerReadRepositoryMock;
        private readonly ICustomerService _customerService;

        public CustomerServiceTest()
        {
            _customerRepositoryMock = new Mock<ICustomerRepository>();
            _customerService = new CustomerService(_customerRepositoryMock.Object);
        }

        private CustomerService GetService()
        {
            _customerRepositoryMock = new Mock<ICustomerRepository>();
            _customerReadRepositoryMock = new Mock<ICustomerReadRepository>();
            return new CustomerService(
                _customerRepositoryMock.Object, _customerReadRepositoryMock);
        }

        [Fact]
        public async void WhenIsNewCustomer_ThenAddCustomer()
        {
            //Arrange
            var service = GetService();
            var name = "John Mayer";
            var email = "JohnMayer@world.com";
            //var customer = new Customer(name, email);

            //_customerRepositoryMock.Setup(x => x.Add(customer));

            //Act
            Customer customer = await service.AddCustomer(name, email);

            //Assert
            Assert.Equal(name, customer.Name);
            Assert.Equal(email, customer.Email);
            _customerRepositoryMock.Verify(x => x.Add(customer), Times.Once);
        }

        [Fact]
        public async void WhenTryToUpdateNonexistentCutomer_ThenNotFoud()
        {
            //Arrange
            var service = GetService();
            var name = "John Mayer";
            var email = "JohnMayer@world.com";
            var oldCustomer = new Customer("John Lennon", "JohnLennon@world.com");
            var newCustomer = new Customer(name, email);

            _customerRepositoryMock.Verify(x => x.GetById(It.IsAny<Guid>()));

            //Act
            var customer = await service.UpdateCustomer(newCustomer);

            //Assert

        }
    }
}
