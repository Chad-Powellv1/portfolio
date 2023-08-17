using Portfolio.Domain.Models;
using Portfolio.Domain.Models.User;

namespace Portfolio.Application.Common.Interfaces.Authentication;

/// <summary name= "IJwtTokenGenerator">
/// The interface for a JWT token generator 
/// that generates a JWT token for an authenticated user.
/// </summary>
public interface IJwtTokenGenerator {
    string GenerateToken(User user);
}
