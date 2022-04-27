using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Interface
{
    public interface IProductReadRepository
    {
        Task<ProductModel> GetById(Guid id);

        Task<List<ProductModel>> GetAll();
    }
}
