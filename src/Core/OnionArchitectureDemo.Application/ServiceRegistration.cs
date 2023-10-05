using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace OnionArchitectureDemo.Application;

public static class ServiceRegistration
{
    public static void ConfigureApplicationRegistration(this IServiceCollection services)
    {
        var asmm = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(asmm);
        services.AddMediatR(cfg=> cfg.RegisterServicesFromAssembly(asmm));
    }
}