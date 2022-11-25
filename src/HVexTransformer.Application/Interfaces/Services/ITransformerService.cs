using HVexTransformer.Application.DTOs.TransformerDTOs;
using HVexTransformer.Application.Result;

namespace HVexTransformer.Application.Interfaces.Services;

public interface ITransformerService
{
    Task<IEnumerable<TransformerResponseDTO>> GetTranformersAsync();
    Task<TransformerResponseDTO> GetTransformerByIdAsync(string id);
    Task<TransformerResponseDTO> AddTransformerAsync(TransformerCreateDTO transformerCreateDTO);
    Task<ServicesResult<TransformerResponseDTO>> UpdateTransformerAsync(string id, TransformerUpdateDTO transformerUpdateDTO);
    Task<ServicesResult<TransformerResponseDTO>> DeleteTransformerAsync(string id);
}
