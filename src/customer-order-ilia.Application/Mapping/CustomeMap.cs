using AutoMapper;
using customer_order_ilia.Application.Models;
using customer_order_ilia.Domain.Entities;

namespace customer_order_ilia.Application.Mapping
{
    public class CustomeMap : Profile
    {
        public CustomeMap()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, c => c.MapFrom(src => src.Email));

            CreateMap<Customer, CustomerInputModel>().ReverseMap()
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, c => c.MapFrom(src => src.Email));            
        }
    }
}
