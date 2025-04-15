using API_CONTAS_PAGAR.Models;
using AutoMapper;

namespace API_CONTAS_PAGAR.Profiles
{
    public class ContaProfile : Profile
    {
        public ContaProfile()
        {
            CreateMap<ContaRequestModel, ContaModel>();
            CreateMap<UsuarioRequestModel, UsuarioModel>();
        }
    }
}
