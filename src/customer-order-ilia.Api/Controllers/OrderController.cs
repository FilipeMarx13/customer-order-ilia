using System;
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
        public OrderController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
