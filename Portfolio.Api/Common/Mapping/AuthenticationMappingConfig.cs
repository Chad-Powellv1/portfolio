using Mapster;
using Portfolio.Application.Authentication.Commands.Register;
using Portfolio.Application.Authentication.Common;
using Portfolio.Application.Authentication.Queries.Login;
using Portfolio.Contracts.Authentication;

namespace Portfolio.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    /// <summary name="Register">
    /// The mapping configuration for authentication, used by Mapster,
    /// to map properties from the source object to the destination object. 
    /// </summary>
    /// <param name="config">
    /// The configuration object for Mapster, used to map properties
    ///  from the source object to the destination object.
    /// </param.
    /// </summary>
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AuthenticationResult, Contracts.Authentication.AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
        config.NewConfig<LoginRequest, LoginQuery>();
        config.NewConfig<RegisterRequest, RegisterCommand>();
    }
}
