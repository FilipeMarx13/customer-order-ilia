using System;
using System.Linq;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Repositories;
using customer_order_ilia.Infrastructure.Context;

namespace customer_order_ilia.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
        }

        public Task AddNewProduct(Product product)
        {
            DataBase.Products.Add(product);
            return Task.CompletedTask;
        }

        public Task<Product> GetById(Guid id)
        {
            return Task.FromResult(DataBase.Products.FirstOrDefault(x => x.Id == id));
        }
    }
}
