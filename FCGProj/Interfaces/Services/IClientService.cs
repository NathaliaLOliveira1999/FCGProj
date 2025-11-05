using FCGProj.Model;

namespace FCGProj.Interfaces.Services
{
    public interface IClientService
    {
        IEnumerable<Client> GetAll();
        Client? GetById(int id);
        void Add(Client client);
    }
}
