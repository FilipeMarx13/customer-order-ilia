using System;
using System.Collections.Generic;

namespace customer_order_ilia.Application.Models
{
    public class OrderOutputModel
    {
        public CustomerModel Customer { get; set; }
        public IEnumerable<ProductModel> Product { get; set; }
        public string Quantity { get; set; }
        public string TotalAmount { get; set; }
    }
}
