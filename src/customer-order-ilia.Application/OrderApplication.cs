using System;
using System.Threading.Tasks;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Interface;

namespace customer_order_ilia.Application
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IOrderService _orderService;
        public OrderApplication(IOrderService orderService)
        {
            _orderService = orderService;

        }

        public async Task<Guid> AddNewOrder(OrderInputModel orderInputModel)
        {
            var order = await _orderService.AddNewOrder(orderInputModel.CustomerId, orderInputModel.ProductId, orderInputModel.Quantity);

            return order;
        }
    }
}
