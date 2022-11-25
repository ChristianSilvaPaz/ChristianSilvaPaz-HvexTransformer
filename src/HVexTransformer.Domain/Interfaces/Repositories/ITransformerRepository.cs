using HVexTransformer.Domain.Entities;

namespace HVexTransformer.Domain.Interfaces.Repositories;

public interface ITransformerRepository
{
    Task<IEnumerable<Transformer>> GetTransformersAsync();
    Task<Transformer> GetTransformerByIdAsync(string id);
    Task<Transformer> AddTransformerAsync(Transformer transformer);
    Task<Transformer> UpdateTransformerAsync(string id, Transformer transformer);
    Task DeleteTransformerAsync(string id);
}
