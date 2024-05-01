using Microsoft.Extensions.DependencyInjection;
using Plantify.Domain.Orders;

namespace Plantify.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });
        
        services.AddTransient<PricingService>();
        
        return services;
    }
    
}