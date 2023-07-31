using Portfolio.Domain.Models;

namespace Portfolio.Application.Services.Authentication;

/// <summary>
/// Represents the result of an authentication attempt.
/// </summary>
/// <param name="User">
/// The authenticated user. If the authentication attempt failed,
///  this will be null.
/// </param>
/// <param name="token">
/// The authentication token. If the authentication attempt failed,
/// this will be null.
/// </param>
/// </summary>
public record AuthenticationResult(
    User User,
    string token);