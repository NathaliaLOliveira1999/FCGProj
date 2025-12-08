using AutoMapper;
using FCGProj.Model;
using FCGProj.Models;
using FCGProj.Models.Dto;

namespace FCGProj.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            // Mapeia DTO -> Entidade
            CreateMap<ClientDto, Client>()
                .ForMember(dest => dest.IdClient, opt => opt.Ignore())
                .ForMember(dest => dest.ClientAddresses, opt => opt.Ignore());

            // (opcional) Entidade -> DTO
            CreateMap<Client, ClientDto>();
        }
    }
}
