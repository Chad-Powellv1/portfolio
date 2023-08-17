using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Common.Interfaces.Authentication;
using Portfolio.Application.Common.Interfaces.Persistence;
using Portfolio.Application.Common.Interfaces.Services;
using Portfolio.Infrastructure.Authentication;
using Portfolio.Infrastructure.Persistence;
using Portfolio.Infrastructure.Services;

namespace Portfolio.Infrastructure;

/// <summary>
/// This class contains the dependency injection
/// for the infrastructure layer.
/// </summary>
public static class DependencyInjection {

    /// <summary name="AddInfrastructure">
    /// This method adds all the dependencies from 
    /// the infrastructure layer to the service collection,
    /// so it can be used in program.cs in the API layer.
    /// </summary>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, Microsoft.Extensions.Configuration.ConfigurationManager configuration) {

        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
}
