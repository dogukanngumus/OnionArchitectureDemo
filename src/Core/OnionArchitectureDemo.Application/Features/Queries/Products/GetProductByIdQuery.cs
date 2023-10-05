using AutoMapper;
using MediatR;
using OnionArchitectureDemo.Application.Dto;
using OnionArchitectureDemo.Application.Interfaces.Repository;

namespace OnionArchitectureDemo.Application.Features.Queries.Products;

public class GetProductByIdQuery : IRequest<ProductViewDto>
{
    public GetProductByIdQuery(Guid ıd)
    {
        Id = ıd;
    }

    public Guid Id { get;}
}

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductViewDto>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductByIdQueryHandler(IMapper mapper, IProductRepository productRepository)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<ProductViewDto> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
       var product = await _productRepository.GetByIdAsync(request.Id);
       return _mapper.Map<ProductViewDto>(product);
    }
}