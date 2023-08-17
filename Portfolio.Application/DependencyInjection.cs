using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace Portfolio.Application;

public static class DependencyInjection {

    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services.AddMediatR(System.Reflection.Assembly.GetExecutingAssembly());
        return services;
    }
}
