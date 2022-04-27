using System;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Application.Interface
{
    public interface ICustomerService
    {
        Task<Customer> AddCustomer(string name, string email);

        Task<Customer> UpdateCustomer (Customer customer);

    }
}
