using AutoMapper;
using Lanchonete.Application.DTOs;
using Lanchonete.Domain.Models;

namespace Lanchonete.Application.Mapping
{
    public class ModelToModelDTOConfigureProfile : Profile
    {
        public ModelToModelDTOConfigureProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Lanche, LancheDTO>().ReverseMap();
        }
    }
}
