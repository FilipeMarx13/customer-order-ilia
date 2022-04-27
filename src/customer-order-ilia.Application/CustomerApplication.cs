using System;
using System.Threading.Tasks;
using AutoMapper;
using customer_order_ilia.Application.Interface;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Repositories;

namespace customer_order_ilia.Application
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;
        private readonly ICustomerRepository _customerRepository;

        public CustomerApplication(ICustomerService customerService, IMapper mapper, ICustomerRepository customerRepository)
        {
            _customerService = customerService;
            _mapper = mapper;
            _customerRepository = customerRepository;
        } 

        public async Task<CustomerModel> UpdateCustomer(CustomerModel customerModel)
        {
            var customer = _mapper.Map<Customer>(customerModel);
            var result = await _customerService.UpdateCustomer(customer);       
            if(result == null)                
                throw new NotImplementedException("Invalid Information");

            return _mapper.Map<CustomerModel>(result);
        }        

        public async Task<CustomerModel> AddCustomer(string name, string email)
        {
            var customer = await _customerService.AddCustomer(name, email);
            return _mapper.Map<CustomerModel>(customer);
        }
    }
}
