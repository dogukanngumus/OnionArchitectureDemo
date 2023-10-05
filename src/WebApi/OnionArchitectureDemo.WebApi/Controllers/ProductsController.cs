using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.Application.Features.Commands;
using OnionArchitectureDemo.Application.Features.Queries.Products;

namespace OnionArchitectureDemo.WebApi.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ProductsController:ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    => Ok(await _mediator.Send(new GetAllProductsQuery()));
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
        => Ok(await _mediator.Send(new GetProductByIdQuery(id)));
    
    
    [HttpPost]
    public async Task<IActionResult> Post(CreateProductCommand command)
    =>  Ok(await _mediator.Send(command));
    
}