using System;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> AddNewOrder(Order order);
        Task<Order> GetById(Guid id);
    }
}
