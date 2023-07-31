using Portfolio.Domain.Models;

namespace Portfolio.Application.Persistence {

    public interface IUserRepository {
    User? GetUserByEmail(string email);
    void Add(User user);

    }
}