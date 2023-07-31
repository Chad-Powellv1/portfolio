namespace Portfolio.Contracts.Authentication;

/// <summary name="RegisterRequest">
/// The request object for registering a new user.
/// </summary>
/// <param name="firstName">
/// The first name of the user.
/// </param>
/// <param name="lastName">
/// The last name of the user.
/// </param>
/// <param name="email">
/// The email address of the user.
/// </param>
/// <param name="password">
/// The password of the user.
/// </param>
public record RegisterRequest(
    string firstName,
    string lastName,
    string email,
    string password);