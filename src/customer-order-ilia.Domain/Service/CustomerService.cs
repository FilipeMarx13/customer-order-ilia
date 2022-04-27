using System;
using System.Threading.Tasks;
using customer_order_ilia.Application.Interface;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Repositories;

namespace customer_order_ilia.Domain.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> AddCustomer(string name, string email)
        {
            var customer = new Customer(name,email);
            await _customerRepository.Add(customer);
            return customer;
        }
             

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            var result = await _customerRepository.GetById(customer.Id);
            if(result == null)
            {
                throw new ArgumentException("Customer not found");
            }

            await _customerRepository.Update(customer);
            return customer;
        }        

    }
}
