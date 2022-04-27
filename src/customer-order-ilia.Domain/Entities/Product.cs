using System;
using System.Collections.Generic;

namespace customer_order_ilia.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {

        }
        public Product(string description, decimal price, int quantity)
        {
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public void UpdatePrice(decimal price)
        {
            Price = price;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }

        public void UpdateQuantity(int quantity)
        {
            Quantity = quantity;
        }

    }
}
