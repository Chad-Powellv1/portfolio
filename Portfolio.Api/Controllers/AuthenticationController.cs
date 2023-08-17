using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Domain.Common.Errors;
using Portfolio.Application.Authentication.Queries.Login;
using Portfolio.Contracts.Authentication;
using MediatR;
using Portfolio.Application.Authentication.Commands;
using Portfolio.Application.Authentication.Commands.Register;
using Portfolio.Application.Authentication.Common;
using Portfolio.Application.Common;

namespace Portfolio.Api.Controllers;


/// <summary name="AuthenticationController">
/// The controller for authentication.
/// </summary>

[Route("auth")]
public class AuthenticationController : ApiController {

    private readonly IMediator _mediator;

    public AuthenticationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);

        return authResult.Match(
            authResult => Ok(MapAuthResult(authResult)),
            errors => Problem(errors));
    }


    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request) {

        var query = new LoginQuery(
            request.Email,
            request.Password);

        var authResult = await _mediator.Send(query);
    
        
        if(authResult.IsError && authResult.FirstError == Errors.Authentication.InvalidCredentials){
            return Problem(statusCode: StatusCodes.Status401Unauthorized,
                title: authResult.FirstError.Description);
        }
        

        return authResult.Match(
            authResult => Ok(MapAuthResult(authResult)),
            errors => Problem(errors));
        
    }
    
        private static AuthenticationResponse MapAuthResult(AuthenticationResult authResult)
    {
        return new AuthenticationResponse(
                    authResult.User.Id,
                    authResult.User.FirstName,
                    authResult.User.LastName,
                    authResult.User.Email,
                    authResult.Token);
    }
}
