using AutoMapper;
using MediatRCqrs.DTO_s;
using MediatRCqrs.Entities;
using MediatRCqrs.MedHandlers.Commands;

namespace MediatRCqrs
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<Product, CreateResponseDto>().ReverseMap();
        }
    }
}
