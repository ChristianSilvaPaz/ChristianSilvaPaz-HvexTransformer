using System.ComponentModel.DataAnnotations;

namespace HVexTransformer.Application.DTOs.UserDTOs;

public class UserCreateDto
{
    [Required(ErrorMessage = "O nome do usuário é obrigatório")]
    public string Name { get; set; }

    [Required(ErrorMessage = "O email do usuário é obrigatório")]
    [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um endereço de email válido")]
    public string Email { get; set; }
}
