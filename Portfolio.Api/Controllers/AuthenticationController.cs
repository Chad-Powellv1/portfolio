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
using MapsterMapper;

namespace Portfolio.Api.Controllers;


/// <summary name="AuthenticationController">
/// The controller for authentication.
/// </summary>

[Route("auth")]
public class AuthenticationController : ApiController
{

    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public AuthenticationController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = _mapper.Map<RegisterRequest, RegisterCommand>(request);

        ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);

        return authResult.Match(
            authResult => Ok(_mapper.Map<AuthenticationResult>(authResult)),
            errors => Problem(errors));
    }


    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {

        var query = _mapper.Map<LoginRequest, LoginQuery>(request);

        var authResult = await _mediator.Send(query);


        if (authResult.IsError && authResult.FirstError == Errors.Authentication.InvalidCredentials)
        {
            return Problem(statusCode: StatusCodes.Status401Unauthorized,
                title: authResult.FirstError.Description);
        }


        return authResult.Match(
            authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
            errors => Problem(errors));

    }

}
