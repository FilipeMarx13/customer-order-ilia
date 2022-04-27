using System;
using AutoMapper;
using customer_order_ilia.Domain.Entities;
using customer_order_ilia.Infrastructure.Models;

namespace customer_order_ilia.Infrastructure.Mapping
{
    public class CustomeMap : Profile
    {
        public CustomeMap()
        {
            CreateMap<Customer, CustomerModel>().ReverseMap()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.Email, c => c.MapFrom(src => src.Email));
        }
    }

}