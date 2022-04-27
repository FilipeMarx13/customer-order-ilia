using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Repositories
{
    public interface ICustomerReadRepository
    {
        Task<CustomerModel> GetById(Guid id);

        Task<List<CustomerModel>> GetAll();
    }
}
