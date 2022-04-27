using System;
namespace customer_order_ilia.Application.Models
{
    public class ProductOutputModel
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
