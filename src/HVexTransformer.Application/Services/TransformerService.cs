using HVexTransformer.Application.DTOs.TransformerDTOs;
using HVexTransformer.Application.Interfaces.Services;
using HVexTransformer.Application.Result;
using HVexTransformer.Domain.Interfaces.Repositories;

namespace HVexTransformer.Application.Services;

public class TransformerService : ITransformerService
{
    private readonly ITransformerRepository _transformerRepository;

    public TransformerService(ITransformerRepository transformerRepository)
    {
        _transformerRepository = transformerRepository;
    }

    public Task<IEnumerable<TransformerResponseDTO>> GetTranformersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TransformerResponseDTO> GetTransformerByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<TransformerResponseDTO> AddTransformerAsync(TransformerCreateDTO transformerCreateDTO)
    {

    }

    public Task<ServicesResult<TransformerResponseDTO>> UpdateTransformerAsync(string id, TransformerUpdateDTO transformerUpdateDTO)
    {
        throw new NotImplementedException();
    }

    public Task<ServicesResult<TransformerResponseDTO>> DeleteTransformerAsync(string id)
    {
        throw new NotImplementedException();
    }
}
