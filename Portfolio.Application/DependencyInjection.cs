using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Services.Authentication;

namespace Portfolio.Application;

public static class DependencyInjection {

    public static IServiceCollection AddApplication(this IServiceCollection services) {

        services.AddScoped<IAuthenticationService, AuthenticationService>();
        
        return services;
    }
}