using HVexTransformer.Application.DTOs.UserDTOs;
using HVexTransformer.Application.Result;

namespace HVexTransformer.Application.Interfaces.Services;

public interface IUserService
{
    Task<IEnumerable<UserResponseDTO>> GetUsersAsync();
    Task<UserResponseDTO> GetUserByIdAsync(string id);
    Task<UserResponseDTO> AddUserAsync(UserCreateDTO userCreateDTO);
    Task<ServicesResult<UserResponseDTO>> UpdateUserAsync(string id, UserUpdateDTO userUpdateDTO);
    Task<ServicesResult<UserResponseDTO>> DeleteUserAsync(string id);
}
