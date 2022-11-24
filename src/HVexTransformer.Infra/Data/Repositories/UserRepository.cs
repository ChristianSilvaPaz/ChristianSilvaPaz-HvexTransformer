using HVexTransformer.Domain.Entities;
using HVexTransformer.Domain.Interfaces.Repositories;
using HVexTransformer.Infra.Context;
using MongoDB.Driver;

namespace HVexTransformerInfra.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly HVexDbContext _context;

    public UserRepository(HVexDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _context.Users.Find(_ => true).ToListAsync();
    }

    public async Task<User> GetUserByIdAsync(string id)
    {
        return await _context.Users.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<User> AddUserAsync(User user)
    {
        await _context.Users.InsertOneAsync(user);
        return user;
    }

    public async Task<User> UpdateUserAsync(string id, User user)
    {
        await _context.Users.ReplaceOneAsync(x => x.Id == id, user);
        return user;
    }

    public async Task DeleteUserAsync(string id)
    {
        await _context.Users.DeleteOneAsync(x => x.Id == id);
    }
}
