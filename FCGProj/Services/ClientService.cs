using AutoMapper;
using FCGProj.Interfaces.Repositories;
using FCGProj.Interfaces.Services;
using FCGProj.Model;
using FCGProj.Models;
using FCGProj.Models.Dto;
using System.Text.RegularExpressions;

namespace FCGProj.Services
{
    public class ClientService : Interfaces.Services.IClientService
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;
        private readonly IUserService _userService;

        public ClientService(IMapper mapper, IClientRepository clientRepository, IUserService userService)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
            _userService = userService;
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public ClientDto? GetById(int id)
        {
            return _mapper.Map<ClientDto>(_clientRepository.GetById(id));
        }

        public ServiceResult Add(ClientDto client)
        {
            client.User.UserName = client.User.UserName.ToUpper();

            var returnEmail = this.ValiteEmail(client.Email);
            if (string.IsNullOrEmpty(client.Name))
                return ServiceResult.Fail("Preencha o nome!");
            if (!string.IsNullOrEmpty(returnEmail))
                return ServiceResult.Fail("E-mail Inválido!" + returnEmail);
            if (client.IdAccessProfile == 0)
                return ServiceResult.Fail("Preencha o perfil do usuário!");
            _userService.Add(client.User);
            _clientRepository.Add(_mapper.Map<Client>(client));
            return ServiceResult.Ok(client);
        }

        private string ValiteEmail(string email)
        {
            email = email.Trim();
            var retorno = "";
            var parts = email.Split('@');
            if (string.IsNullOrEmpty(email))
                retorno += "E-mail precisa ser preenchido.";
            if (!email.Contains("@") || parts.Length != 2 || parts[0].Length == 0 || parts[0].Length > 64 || parts[0].StartsWith(".") || parts[0].EndsWith(".") || parts[0].Contains(".."))
                retorno += "E-mail inválido.";
            return retorno;
        }

    }
}
