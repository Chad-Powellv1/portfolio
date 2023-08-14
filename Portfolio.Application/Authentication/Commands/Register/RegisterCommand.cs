using ErrorOr;
using MediatR;
using Portfolio.Application.Authentication.Common;


namespace Portfolio.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
