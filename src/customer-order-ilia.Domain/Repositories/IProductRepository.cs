using System;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Domain.Repositories
{
    public interface IProductRepository
    {
        Task AddNewProduct(Product product);
        Task<Product> GetById(Guid id);
    }
}
