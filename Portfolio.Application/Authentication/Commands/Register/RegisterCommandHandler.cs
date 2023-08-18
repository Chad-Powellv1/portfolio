using MediatR;
using ErrorOr;
using Portfolio.Application.Authentication.Common;
using Portfolio.Application.Common.Interfaces.Authentication;
using Portfolio.Application.Common.Interfaces.Persistence;
using Portfolio.Domain.Common.Errors;
using Portfolio.Domain.Models.User;


namespace Portfolio.Application.Authentication.Commands.Register;

public class RegisterCommandHandler :
    IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRespository;

    public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRespository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRespository = userRespository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        if (_userRespository.GetUserByEmail(command.Email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }

        var user = new User
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            Password = command.Password
        };

        _userRespository.Add(user);

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}


