using System;
using System.Threading.Tasks;
using AutoMapper;
using customer_order_ilia.Api.Controllers;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Infrastructure.Models;
using customer_order_ilia.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace customer_order_ilia.Tests.Controller
{
    public class CustomerControllerTest
    {
        private Mock<ICustomerApplication> _customerApplicationMock;
        private Mock<ICustomerReadRepository> _customerReadRepositoryMock;
        private Mock<IMapper> _mapperMock;

        private CustomerController GetController()
        {
            _customerApplicationMock = new Mock<ICustomerApplication>();
            _customerReadRepositoryMock = new Mock<ICustomerReadRepository>();

            return new CustomerController(_customerReadRepositoryMock.Object, _customerApplicationMock.Object);
        }

        [Fact]
        public async Task WhenGetCustomer_ReturnSuccess()
        {
            //Arrange
            var service = GetController();
            var guid = Guid.NewGuid();
            var customer = new Customer();
            var customerModel = new Infrastructure.Models.CustomerModel();

            _customerReadRepositoryMock.Setup(x => x.GetById(It.IsAny<Guid>())).ReturnsAsync(customerModel);

            //Act
            var result = await service.Get(guid);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task WhenGetCustomer_ReturnNotFound()
        {
            //Arrange
            var service = GetController();
            var guid = Guid.NewGuid();
            
            //Act
            var result = await service.Get(guid);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task WhenGetCustomerList_ReturnSuccess()
        {
            //Arrange
            var service = GetController();
            var guid = Guid.NewGuid();
            var customer = new Customer();
            var customerModel = new Infrastructure.Models.CustomerModel();

            _customerReadRepositoryMock.Setup(x => x.GetById(It.IsAny<Guid>())).ReturnsAsync(customerModel);

            //Act
            var result = await service.GetAll();

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task WhenIsANewUser_ThenAddCustomer()
        {
            //Arrange
            var service = GetController();
            CustomerInputModel custumerInput = new CustomerInputModel { Name = "John", Email="teste@teste.com"};          
            var customerapp = new Application.Models.CustomerModel();

            _customerApplicationMock.Setup(x => x.AddCustomer(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(customerapp);

            //Act
            var result = await service.Post(custumerInput);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public async Task WhenNeedUpdateCustomer()
        {
            //Arrange
            var service = GetController();
            CustomerInputModel custumerInput = new CustomerInputModel { Name = "John", Email = "teste@teste.com" };
            var customerapp = new Application.Models.CustomerModel();
            var customerModel = new Infrastructure.Models.CustomerModel();

            _customerReadRepositoryMock.Setup(x => x.GetById(It.IsAny<Guid>())).ReturnsAsync(customerModel);
            _customerApplicationMock.Setup(x => x.AddCustomer(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync(customerapp);

            //Act
            var result = await service.Put(customerapp);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
