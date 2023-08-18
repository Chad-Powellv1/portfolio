namespace Portfolio.Contracts.Authentication;

/// <summary name="AuthenticationResponse">
/// The response object for authentication.
/// </summary>
/// <param name="Guid Id">
/// The unique identifier of the user.
/// </param>
/// <param name="string firstName">
/// The first name of the user.
/// </param>
/// <param name="string lastName">
/// The last name of the user.
/// </param>
/// <param name="string email">
/// The email address of the user.
/// </param>
/// <param name="string token">
/// The JWT token for the user.
/// </param>
public record AuthenticationResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);
