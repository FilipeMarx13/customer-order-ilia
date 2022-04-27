using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using customer_order_ilia.Infrastructure.Context;
using customer_order_ilia.Infrastructure.Interface;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure
{
    public class OrderReadRepository : IOrderReadRepository
    {
        public Task<List<OrderModel>> GetAll()
        {
            var orders = (from o in DataBase.Orders
                          select new OrderModel()
                          {
                              Id = o.Id,
                              CreatedAt = o.CreatedAt,
                              CustomerName = o.Customer.Name,
                              CustomerEmail = o.Customer.Email,
                              ProductDescription = o.Product.Description,
                              ProductPrice = o.Product.Price,
                              ProductQuantity = o.Product.Quantity,
                              TotalPrice = o.TotalPrice
                          }).ToList();

            return Task.FromResult(orders);
        }

        public Task<OrderModel> GetById(Guid id)
        {
            var order = (from o in DataBase.Orders
                         where o.Id == id
                         select new OrderModel()
                         {
                             Id = o.Id,
                             CreatedAt = o.CreatedAt,
                             CustomerName = o.Customer.Name,
                             CustomerEmail = o.Customer.Email,
                             ProductDescription = o.Product.Description,
                             ProductPrice = o.Product.Price,
                             ProductQuantity = o.Product.Quantity,
                             TotalPrice = o.TotalPrice
                         }).FirstOrDefault();

            return Task.FromResult(order);
        }

        
    }
}
