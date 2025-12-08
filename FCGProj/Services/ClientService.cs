using AutoMapper;
using FCGProj.Interfaces.Repositories;
using FCGProj.Model;
using FCGProj.Models;
using System.Text.RegularExpressions;

namespace FCGProj.Services
{
    public class ClientService : Interfaces.Services.IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client? GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public ServiceResult Add(ClientDTO client)
        {
            client.ClientUser = client.ClientUser.ToUpper();
            var returnPassword = this.ValitePassword(client.Password);
            var returnEmail = this.ValiteEmail(client.Email);
            if (string.IsNullOrEmpty(client.Name))
                return ServiceResult.Fail("Preencha o nome!");
            if (!string.IsNullOrEmpty(returnPassword))
                return ServiceResult.Fail("Senha Inválida!" + returnPassword);
            if (!string.IsNullOrEmpty(returnEmail))
                return ServiceResult.Fail("E-mail Inválido!" + returnEmail);
            if (client.IdAccessProfile == 0)
                return ServiceResult.Fail("Preencha o perfil do usuário!");
            // TODO VALIDAÇAO USER EXISTENTE
            //var existing = await _clientRepository.GetByUserAsync(client.ClientUser);
            //if (existing != null && existing.Any())
            //    return ServiceResult.Fail("clientUser já existe na base!");
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

        private string ValitePassword(string password)
        {
            var retorno = "";
            if (string.IsNullOrEmpty(password) || password.Length < 8)
                retorno += "Senha deve conter 8 caracteres ou mais.";
            if (Regex.Matches(password, @"[^\p{L}\p{Nd}\s]").Count == 0)
                retorno += "Senha deve conter ao menos um caracter especial.";
            if (Regex.Matches(password, @"\p{Lu}").Count == 0 || Regex.Matches(password, @"\p{Ll}").Count == 0)
                retorno += "Senha deve conter letras maiusculas e minusculas.";
            if (Regex.Matches(password, @"\p{Nd}").Count == 0)
                retorno += "Senha deve conter ao menos um número.";
            return retorno;
        }
    }
}
