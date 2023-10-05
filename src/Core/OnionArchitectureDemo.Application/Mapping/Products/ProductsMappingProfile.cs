using AutoMapper;
using OnionArchitectureDemo.Application.Dto;
using OnionArchitectureDemo.Application.Features.Commands;
using OnionArchitectureDemo.Domain.Entities;

namespace OnionArchitectureDemo.Application.Mapping.Products;

public class ProductsMappingProfile : Profile
{
    public ProductsMappingProfile()
    {
        CreateMap<Product, ProductViewDto>().ReverseMap();
        CreateMap<Product, CreateProductCommand>().ReverseMap();
    }
}