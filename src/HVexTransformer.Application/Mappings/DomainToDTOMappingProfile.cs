using AutoMapper;
using HVexTransformer.Application.DTOs.UserDTOs;
using HVexTransformer.Domain.Entities;

namespace HVexTransformer.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<User, UserResponseDTO>();
    }
}
