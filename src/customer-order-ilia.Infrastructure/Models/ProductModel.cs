using System;
namespace customer_order_ilia.Infrastructure.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
