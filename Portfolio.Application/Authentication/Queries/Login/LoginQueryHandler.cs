using ErrorOr;
using MediatR;
using Portfolio.Application.Authentication.Common;
using Portfolio.Application.Common.Interfaces.Authentication;
using Portfolio.Application.Common.Interfaces.Persistence;
using Portfolio.Domain.Common.Errors;
using Portfolio.Domain.Models.User;


namespace Portfolio.Application.Authentication.Queries.Login;

public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public LoginQueryHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        if (_userRepository.GetUserByEmail(request.Email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }

        if (!user.Password.Equals(request.Password))
        {
            return Errors.Authentication.InvalidCredentials;
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}
