namespace Portfolio.Contracts.Authentication;

/// <summary name="RegisterRequest">
/// The request object for registering a new user.
/// </summary>
/// <param name="FirstName">
/// The first name of the user.
/// </param>
/// <param name="LastName">
/// The last name of the user.
/// </param>
/// <param name="Email">
/// The email address of the user.
/// </param>
/// <param name="Password">
/// The password of the user.
/// </param>
public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password);
