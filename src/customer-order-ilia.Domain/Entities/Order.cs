using System;
using System.Collections.Generic;

namespace customer_order_ilia.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {

        }
        
        public Order(Customer customer, Product product, int quantity)
        {
            Customer = customer;
            CreatedAt = DateTime.Now; ;
            Product = product;
            Quantity = quantity;
            TotalPrice = quantity * Product.Price;
        }

        public Customer Customer { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public decimal TotalPrice { get; private set; }

        
        public void AddCustomer(Customer customer)
        {
            Customer = customer;
        }

        public void AddProduct(Product product)
        {
            Product = product;
        }

        public void SetQuantity(Product product, int quantity)
        {
            product.UpdateQuantity(quantity);
        }
    }
}
