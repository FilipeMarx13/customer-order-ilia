using System;
namespace customer_order_ilia.Application.Models
{
    public class OrderInputModel
    {
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; } 
    }
}
