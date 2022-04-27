using System;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task Add(Customer customer);

        Task Update(Customer customer);

        Task<Customer> GetById(Guid id);
    }
}
