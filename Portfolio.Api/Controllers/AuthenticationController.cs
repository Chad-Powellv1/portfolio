using Microsoft.AspNetCore.Mvc;
using Portfolio.Contracts.Authentication;
using Portfolio.Application.Services.Authentication;

namespace Portfolio.Api.Controllers;


/// <summary name="AuthenticationController">
/// The controller for authentication.
/// </summary>

[ApiController]
[Route("auth")]
public class AuthenticationController :ControllerBase {

    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService) {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request) {

        var authResult = _authenticationService.Register(
            request.firstName,
            request.lastName,
            request.email,
            request.password);

        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.token);

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request) {

        var authResult = _authenticationService.Login(
            request.email,
            request.password);

        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.token);

        return Ok(response);
    }
    
}