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
                .ForMember(dest => dest.IdClient, opt => opt.Ignore());
            
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.IdUser, opt => opt.Ignore());

            // (opcional) Entidade -> DTO
            CreateMap<Client, ClientDto>();
            CreateMap<User, UserDto>();
        }
    }
}
