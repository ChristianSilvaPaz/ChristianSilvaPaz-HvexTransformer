using HVexTransformer.Application.DTOs.UserDTOs;
using HVexTransformer.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace HVexTransformer.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserResponseDTO>>> GetUsersAsync()
    {
        var users = await _userService.GetUsersAsync();
        return users is not null ? Ok(users) : NotFound("Não há usuários cadastrados");
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserResponseDTO>> GetUserAsync(string id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        return user is not null ? Ok(user) : NotFound("Usuário não encontrado");
    }

    [HttpPost]
    public async Task<ActionResult<UserResponseDTO>> AddUserAsync([FromBody] UserCreateDTO userCreateDto)
    {
        var user = await _userService.AddUserAsync(userCreateDto);
        return Ok(user);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<UserResponseDTO>> UpdateUserAsync(string id, [FromBody] UserUpdateDTO userUpdateDTO)
    {
        var result = await _userService.UpdateUserAsync(id, userUpdateDTO);
        return !result.Errors.Any() ? Ok(result.Data) : BadRequest(result.Errors);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<UserResponseDTO>> DeleteUserAsync(string id)
    {
        var result = await _userService.DeleteUserAsync(id);
        return !result.Errors.Any() ? NoContent() : BadRequest(result.Errors);
    }
}
