using System;
using System.Linq;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Repositories;
using customer_order_ilia.Infrastructure.Context;

namespace customer_order_ilia.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task Add(Customer customer)
        {
            DataBase.Customers.Add(customer);
            return Task.CompletedTask;

        }

        public Task<Customer> GetById(Guid id)
        {
            return Task.FromResult(DataBase.Customers.FirstOrDefault(x => x.Id == id));
        }

        public Task Update(Customer customer)
        {
            var customerUpdate = DataBase.Customers.FirstOrDefault(x => x.Id == customer.Id);
            customerUpdate.UpdateName(customer.Name);
            customerUpdate.UpdateEmail(customer.Email);
            return Task.CompletedTask;
        }
    }
}
