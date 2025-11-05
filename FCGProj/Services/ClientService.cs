using FCGProj.Interfaces.Repositories;
using FCGProj.Model;

namespace FCGProj.Services
{
    public class ClientService : Interfaces.Services.IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client? GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void Add(Client client)
        {
            _clientRepository.Add(client);
        }
    }
}
