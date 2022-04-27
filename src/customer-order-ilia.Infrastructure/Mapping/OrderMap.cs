using System;
using AutoMapper;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Mapping
{
    public class OrderMap : Profile
    {
        public OrderMap()
        {
            CreateMap<Order, OrderModel>().ReverseMap()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedAt, c => c.MapFrom(src => src.CreatedAt))                
                .ForMember(dest => dest.TotalPrice, c => c.MapFrom(src => src.TotalPrice))
                .ForPath(dest => dest.Customer.Name, opts => opts.MapFrom(src => src.CustomerName))
                .ForPath(dest => dest.Customer.Email, opts => opts.MapFrom(src => src.CustomerEmail))
                .ForPath(dest => dest.Product.Description, opts => opts.MapFrom(src => src.ProductDescription))
                .ForPath(dest => dest.Product.Price, opts => opts.MapFrom(src => src.ProductPrice))
                .ForPath(dest => dest.Product.Quantity, opts => opts.MapFrom(src => src.ProductQuantity));
        }
    }
}
