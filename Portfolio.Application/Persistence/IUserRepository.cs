
using Portfolio.Domain.Models;
using Portfolio.Domain.Models.User;

namespace Portfolio.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);

}

