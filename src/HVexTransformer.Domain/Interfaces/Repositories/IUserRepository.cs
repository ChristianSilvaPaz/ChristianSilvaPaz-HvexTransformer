using HVexTransformer.Domain.Entities;

namespace HVexTransformer.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByIdAsync(string id);
    Task<User> AddUserAsync(User user);
    Task<User> UpdateUserAsync(string id, User user);
    Task DeleteUserAsync(string id);
}
