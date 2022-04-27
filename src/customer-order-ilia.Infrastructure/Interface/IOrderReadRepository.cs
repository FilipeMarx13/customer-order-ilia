using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Interface
{
    public interface IOrderReadRepository
    {
        Task<OrderModel> GetById(Guid Id);

        Task<List<OrderModel>> GetAll();
    }
}
