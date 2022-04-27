using System;
using System.Threading.Tasks;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace customer_order_ilia.Api.Controllers
{
    /// <summary>
    /// Controller Order
    /// </summary>
    [ApiController]
    [Route("customer-order-ilia/order")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderApplication _orderApplication;
        private readonly IOrderReadRepository _orderReadRepository;
        public OrderController(IOrderApplication orderApplication, IOrderReadRepository orderReadRepository)
        {
            _orderApplication = orderApplication;
            _orderReadRepository = orderReadRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(OrderInputModel orderInputModel)
        {
            var order = await _orderApplication.AddNewOrder(orderInputModel);            
            return Ok(order);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderReadRepository.GetAll();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var orders = await _orderReadRepository.GetById(id);
            if(orders == null)
                return NotFound();
            return Ok(orders);
        }
    }
}
