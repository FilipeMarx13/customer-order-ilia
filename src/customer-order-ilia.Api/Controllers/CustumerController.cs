using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace customer_order_ilia.Api.Controllers
{
    /// <summary>
    /// Controller Customer
    /// </summary>
    [ApiController]
    [Route("customer-order-ilia/customer")]
    public class CustomerController : ControllerBase
    {
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