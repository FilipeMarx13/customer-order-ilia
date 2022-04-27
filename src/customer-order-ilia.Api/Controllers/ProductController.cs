using System;
using System.Threading.Tasks;
using AutoMapper;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Repositories;
using customer_order_ilia.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace customer_order_ilia.Api.Controllers
{
    /// <summary>
    /// Controller Product
    /// </summary>
    [ApiController]
    [Route("customer-order-ilia/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductApplication _productApplication;
        private readonly IMapper _mapper;
        private readonly IProductReadRepository _productReadRepository;

        public ProductController(IProductRepository productRepository, IMapper mapper, IProductApplication productApplication, IProductReadRepository productReadRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _productApplication = productApplication;
            _productReadRepository = productReadRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductModel productModel)
        {
            var customer = await _productApplication.AddNewProduct(productModel);
            if (customer == null)
                return NotFound();
            return Ok("Product created successufully");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var custumers = await _productReadRepository.GetAll();
            return Ok(custumers);
        }

    }
}
