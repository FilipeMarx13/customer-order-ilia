using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using customer_order_ilia.Infrastructure.Context;
using customer_order_ilia.Infrastructure.Interface;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Repositories
{
    public class ProductReadRepository : IProductReadRepository
    {
        public Task<ProductModel> GetById(Guid id)
        {
            var product = (from p in DataBase.Products
                           where p.Id == id
                            select new ProductModel()
                            {
                                Id = p.Id,
                                Description = p.Description,
                                Price = p.Price,
                                Quantity = p.Quantity
                            }).FirstOrDefault();
            return Task.FromResult(product);            
        }

        public Task<List<ProductModel>> GetAll()
        {
            var products = (from p in DataBase.Products
                            select new ProductModel()
                            {
                                Id = p.Id,
                                Description = p.Description,
                                Price = p.Price,
                                Quantity = p.Quantity
                            }).ToList();
            return Task.FromResult(products);
        }
        
    }
}
