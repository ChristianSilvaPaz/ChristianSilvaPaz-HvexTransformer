using HVexTransformer.Domain.Entities;
using HVexTransformer.Domain.Interfaces.Repositories;
using HVexTransformer.Infra.Context;
using MongoDB.Driver;

namespace HVexTransformer.Infra.Data.Repositories;

public class TransformerRepository : ITransformerRepository
{
    private readonly HVexDbContext _context;

    public TransformerRepository(HVexDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Transformer>> GetTransformersAsync()
    {
        return await _context.Transformes.Find(_ => true).ToListAsync();
    }

    public async Task<Transformer> GetTransformerByIdAsync(string id)
    {
        return await _context.Transformes.Find(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Transformer> AddTransformerAsync(Transformer transformer)
    {
        await _context.Transformes.InsertOneAsync(transformer);
        return transformer;
    }

    public async Task<Transformer> UpdateTransformerAsync(string id, Transformer transformer)
    {
        await _context.Transformes.ReplaceOneAsync(x => x.Id == id, transformer);
        return transformer;
    }

    public async Task DeleteTransformerAsync(string id)
    {
        await _context.Transformes.DeleteOneAsync(x => x.Id == id);
    }
}
