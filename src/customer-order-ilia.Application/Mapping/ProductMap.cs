using AutoMapper;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Application.Mapping
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ProductModel>().ReverseMap()
                .ForMember(dest => dest.Price, p => p.MapFrom(src => src.Price))
                .ForMember(dest => dest.Description, p => p.MapFrom(src => src.Description));
           
            CreateMap<Product, ProductOutputModel>().ReverseMap()
                .ForMember(dest => dest.Id, p => p.MapFrom(src => src.Id))
                .ForMember(dest => dest.Price, p => p.MapFrom(src => src.Price))
                .ForMember(dest => dest.Description, p => p.MapFrom(src => src.Description));
        }
    }
}
