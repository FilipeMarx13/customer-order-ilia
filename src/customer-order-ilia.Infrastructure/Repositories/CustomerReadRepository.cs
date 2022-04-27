using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using customer_order_ilia.Infrastructure.Context;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Repositories
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        public Task<CustomerModel> GetById(Guid id)
        {
            var customer = (from c in DataBase.Customers
                           where c.Id == id
                           select new CustomerModel()
                           {
                               Id = c.Id,
                               Name = c.Name,
                               Email = c.Email
                           }).FirstOrDefault();
            return Task.FromResult(customer);
        }

        public Task<List<CustomerModel>> GetAll()
        {
            var customer = (from c in DataBase.Customers
                            select new CustomerModel()
                            {
                                Id = c.Id,
                                Name = c.Name,
                                Email = c.Email
                            }).ToList();
            return Task.FromResult(customer);
        }
    }
}
