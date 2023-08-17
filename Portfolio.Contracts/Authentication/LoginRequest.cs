namespace Portfolio.Contracts.Authentication;

/// <summary name="LoginRequest">
/// The request object for logging in a user.
/// </summary>
/// <param name="email">
/// The email address of the user.
/// </param>
/// <param name="password">
/// The password of the user.
/// </param>
public record LoginRequest(
    string Email,
    string Password);
