using System;
using System.Threading.Tasks;
using AutoMapper;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Repositories;
using customer_order_ilia.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace customer_order_ilia.Api.Controllers
{
    /// <summary>
    /// Controller Customer
    /// </summary>
    [ApiController]
    [Route("customer-order-ilia/customer")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerApplication _customerApplication;

        public CustomerController(ICustomerReadRepository customerReadRepository, ICustomerApplication customerApplication)
        {
            _customerReadRepository = customerReadRepository;
            _customerApplication = customerApplication;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var custumers =  await _customerReadRepository.GetAll();
            return Ok(custumers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var customer = await _customerReadRepository.GetById(id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CustomerModel customerModel)
        {
            var customer = await _customerReadRepository.GetById(customerModel.Id);

            if (customer == null) return NotFound();

            await _customerApplication.UpdateCustomer(customerModel);            
            return Ok("Customer information successfully changed");
        }

        [HttpPost]
        public async Task<IActionResult> Post(CustomerInputModel customerInputModel)
        {
            var customer = await _customerApplication.AddCustomer(customerInputModel.Name, customerInputModel.Email);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }
    }
}