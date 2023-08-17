using ErrorOr;
using MediatR;
using Portfolio.Application.Authentication.Common;
using Portfolio.Application.Common;
using Portfolio.Domain.Models;

namespace Portfolio.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;
