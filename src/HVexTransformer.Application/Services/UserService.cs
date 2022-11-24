using AutoMapper;
using HVexTransformer.Application.DTOs.UserDTOs;
using HVexTransformer.Application.Interfaces.Services;
using HVexTransformer.Application.Result;
using HVexTransformer.Domain.Entities;
using HVexTransformer.Domain.Interfaces.Repositories;

namespace HVexTransformer.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserResponseDTO>> GetUsersAsync()
    {
        var users = await _userRepository.GetUsersAsync();
        return _mapper.Map<IEnumerable<UserResponseDTO>>(users);
    }

    public async Task<UserResponseDTO> GetUserByIdAsync(string id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        return _mapper.Map<UserResponseDTO>(user);
    }

    public async Task<UserResponseDTO> AddUserAsync(UserCreateDto userCreateDTO)
    {
        var userEntity = new User(userCreateDTO.Name, userCreateDTO.Email);
        await _userRepository.AddUserAsync(userEntity);
        return _mapper.Map<UserResponseDTO>(userEntity);
    }

    public async Task<ServicesResult<UserResponseDTO>> UpdateUserAsync(string id, UserUpdateDTO userUpdateDTO)
    {
        var result = new ServicesResult<UserResponseDTO>();
        var userEntity = await _userRepository.GetUserByIdAsync(id);

        if (userEntity is null)
        {
            result.AddErrors("Usuário", "Usuário não encontrado");
            return result;
        }

        userEntity.UpdateUser(userUpdateDTO.Email, userUpdateDTO.Name);
        await _userRepository.UpdateUserAsync(id, userEntity);

        return result.WithData(_mapper.Map<UserResponseDTO>(userEntity));
    }

    public async Task<ServicesResult<UserResponseDTO>> DeleteUserAsync(string id)
    {
        var result = new ServicesResult<UserResponseDTO>();
        var userEntity = await _userRepository.GetUserByIdAsync(id);

        if (userEntity is null)
        {
            result.AddErrors("Usuário", "Usuário não encontrado");
            return result;
        }

        await _userRepository.DeleteUserAsync(id);
        return result.WithData(_mapper.Map<UserResponseDTO>(userEntity));
    }
}
