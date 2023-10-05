using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureDemo.Application.Interfaces.Repository;
using OnionArchitectureDemo.Persistence.Context;
using OnionArchitectureDemo.Persistence.Repositories;

namespace OnionArchitectureDemo.Persistence;

public static class ServiceRegistration
{
    public static void ConfigurePersistenceServices(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseInMemoryDatabase("OnionArchitectureDemoDb");
        });
    }
}