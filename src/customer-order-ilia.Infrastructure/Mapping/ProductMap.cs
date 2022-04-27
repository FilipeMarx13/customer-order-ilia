using AutoMapper;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Mapping
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ProductModel>().ReverseMap()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Price, c => c.MapFrom(src => src.Price))
                .ForMember(dest => dest.Description, c => c.MapFrom(src => src.Description));
        }
    }

}