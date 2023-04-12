using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class EnderecoProfiler : Profile
{
    public EnderecoProfiler()
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<ReadEnderecoDto, Endereco>();
        CreateMap<UpdateEnderecoDto, Endereco>();
    }
}
