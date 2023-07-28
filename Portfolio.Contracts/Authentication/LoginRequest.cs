namespace Portfolio.Contracts.Authentication;

/// <summary name="LoginRequest">
/// The request object for logging in a user.
/// </summary>
/// <param name="Email">
/// The email address of the user.
/// </param>
/// <param name="Password">
/// The password of the user.
/// </param>
public record LoginRequest(
    string Email,
    string Password);