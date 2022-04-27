using System;
using System.Linq;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Repositories;
using customer_order_ilia.Infrastructure.Context;

namespace customer_order_ilia.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<Order> AddNewOrder(Order order)
        {
            DataBase.Orders.Add(order);
            return Task.FromResult(DataBase.Orders.FirstOrDefault(x => x.Id == order.Id));
        }

        public Task<Order> GetById(Guid id)
        {
            return Task.FromResult(DataBase.Orders.FirstOrDefault(x => x.Id == id));             
        }
    }
}
