using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Domain.Interface;
using customer_order_ilia.Domain.Repositories;

namespace customer_order_ilia.Domain.Service
{
    public class OrderService : IOrderService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;

        public OrderService(ICustomerRepository customerRepository, IProductRepository productRepository, IOrderRepository orderRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
        }

        public async Task<Guid> AddNewOrder(Guid customerId, Guid productId, int quantity)
        {
            var customer = await _customerRepository.GetById(customerId);
            var product = await _productRepository.GetById(productId);
            
            var newOrder = CreateNewOrder(customer, product, quantity);

            var order = await _orderRepository.AddNewOrder(newOrder);

            return order.Id;
        }

        private Order CreateNewOrder(Customer customer, Product product, int quantity)
        {
            var order = new Order(customer, product, quantity);
            order.AddCustomer(customer);
            order.AddProduct(product);
            order.SetQuantity(product, quantity);

            return order;
        }
    }

}
