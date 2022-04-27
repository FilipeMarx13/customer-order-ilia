using System;
using System.Threading.Tasks;
using customer_order_ilia.Application.Models;

namespace customer_order_ilia.Application.Interfaces
{
    public interface ICustomerApplication
    {
        Task<CustomerModel> UpdateCustomer(CustomerModel customerModel);
        Task<CustomerModel> AddCustomer(string name, string email);
    }
}
