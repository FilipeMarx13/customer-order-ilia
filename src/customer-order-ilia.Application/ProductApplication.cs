using System;
using System.Threading.Tasks;
using AutoMapper;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Repositories;

namespace customer_order_ilia.Application
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductApplication(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductOutputModel> AddNewProduct(ProductModel productModel)
        {
            var product = _mapper.Map<Product>(productModel);
            await _productRepository.AddNewProduct(product);

            return _mapper.Map<ProductOutputModel>(product);
        }
    }
}
