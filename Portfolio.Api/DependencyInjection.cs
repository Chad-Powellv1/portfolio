
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Api.Common.Errors;
using Portfolio.Api.Common.Mapping;

namespace Portfolio.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddMappings();
        services.AddSingleton<ProblemDetailsFactory, PortfolioProblemDetailsFactory>();
        return services;
    }
}

