using Microsoft.AspNetCore.Mvc.Infrastructure;
using Portfolio.Api.Common.Errors;
using Portfolio.Application;
using Portfolio.Infrastructure;


var builder = WebApplication.CreateBuilder(args);
{

    builder.Services.AddControllers();
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);
       
    builder.Services.AddSingleton<ProblemDetailsFactory, PortfolioProblemDetailsFactory>();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
