using System.Collections.Generic;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Infrastructure.Context
{
    public class DataBase
    {
        private static DataBase _instance;

        public DataBase()
        {
        }

        public static List<Customer> Customers { get; set; } = new List<Customer>()
        {
            new Customer("Joao", "joao@teste.com"),
            new Customer("Maria", "maria@teste.com"),
        };

        public static List<Order> Orders { get; set; } = new List<Order>()
        {
            new Order(new Customer("Joao", "joao@teste.com"),new Product("Juice", 3, 1),1),
            new Order(new Customer("Maria", "maria@teste.com"), new Product("Pizza", 15, 1),2),

        };

        public static List<Product> Products { get; set; } = new List<Product>()
        {
            new Product("Water", 3, 1),
            new Product("Fizzy Drinks", 5, 1),
            new Product("Chicken Snack", 5, 1)
        };

        public DataBase GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataBase();
            }
            return _instance;
        }
    }
}
