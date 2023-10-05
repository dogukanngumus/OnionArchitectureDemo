using OnionArchitectureDemo.Application.Interfaces.Repository;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.Persistence.Context;

namespace OnionArchitectureDemo.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}