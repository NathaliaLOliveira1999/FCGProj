using AutoMapper;
using FCGProj.Model;
using FCGProj.Models;

namespace FCGProj.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            // Mapeia DTO -> Entidade
            CreateMap<ClientDTO, Client>()
                .ForMember(dest => dest.IdClient, opt => opt.Ignore())
                .ForMember(dest => dest.ClientAddresses, opt => opt.Ignore());

            // (opcional) Entidade -> DTO
            CreateMap<Client, ClientDTO>();
        }
    }
}
