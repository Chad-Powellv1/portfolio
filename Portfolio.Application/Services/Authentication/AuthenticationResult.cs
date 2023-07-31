namespace Portfolio.Application.Services.Authentication;

/// <summary name="AuthenticationResult">
/// The result of an authentication request.
/// </summary>
/// <param name="Id">
/// The id of an authenticated user.
/// </param>
/// <param name="firstName">
/// The first name of an authenticated user.
/// </param>
/// <param name="lastName">
/// The last name of an authenticated user.
/// </param>
/// <param name="email">
/// The email of an authenticated user.
/// </param>
/// <param name="token">
/// The token of an authenticated user.
/// </param>
public record AuthenticationResult(
    Guid Id,
    string firstName,
    string lastName,
    string email,
    string token);