using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace StoreApp.Infrastructe.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductDtoForInstertion,Product>();
            CreateMap<ProductDtoForUpdate,Product>().ReverseMap();
        }
    }
}