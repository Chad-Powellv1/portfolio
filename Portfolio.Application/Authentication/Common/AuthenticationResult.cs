using Portfolio.Domain.Models.User;

namespace Portfolio.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);
