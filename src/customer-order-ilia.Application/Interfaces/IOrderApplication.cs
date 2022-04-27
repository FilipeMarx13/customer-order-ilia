using System;
using System.Threading.Tasks;
using customer_order_ilia.Application.Models;

namespace customer_order_ilia.Application.Interfaces
{
    public interface IOrderApplication
    {
        Task<Guid> AddNewOrder(OrderInputModel orderInputModel);
    }
}
