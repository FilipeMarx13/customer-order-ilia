using customer_order_ilia.Application;
using customer_order_ilia.Application.Interface;
using customer_order_ilia.Application.Interfaces;
using customer_order_ilia.Domain.Interface;
using customer_order_ilia.Domain.Repositories;
using customer_order_ilia.Domain.Service;
using customer_order_ilia.Infrastructure;
using customer_order_ilia.Infrastructure.Interface;
using customer_order_ilia.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace customer_order_ilia.CrossCutting.IoC
{
    public static class DependencyResolver
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterApplications(services);
            RegisterDomainService(services);
            RegisterRepositories(services);
        }

        private static void RegisterApplications(IServiceCollection services)
        {
            services.AddScoped<ICustomerApplication, CustomerApplication>();
            services.AddScoped<IOrderApplication, OrderApplication>();
            services.AddScoped<IProductApplication, ProductApplication>();
        }

        private static void RegisterDomainService(IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
        }

    }
}
