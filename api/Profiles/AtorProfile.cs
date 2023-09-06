using api.Data.Dtos;
using api.Models;
using AutoMapper;

namespace api.Profiles;

public class AtorProfile : Profile
{
    public AtorProfile()
    {
        CreateMap<Ator, CreateAtorDto>();
        CreateMap<CreateAtorDto, Ator>();
        CreateMap<Ator, RetornoAtorDto>();
    }
}
