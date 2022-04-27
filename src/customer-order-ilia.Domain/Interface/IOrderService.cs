using System;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Domain.Interface
{
    public interface IOrderService
    {
        Task<Guid> AddNewOrder(Guid customerId, Guid productId, int quantity);
    }
}
