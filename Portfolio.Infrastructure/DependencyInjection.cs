using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Common.interfaces.Authentication;
using Portfolio.Application.Common.Interfaces.Services;
using Portfolio.Infrastructure.Authentication;
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

        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}