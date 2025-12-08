using FCGProj.Model;

namespace FCGProj.Interfaces.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
        Client? GetById(int id);
        void Add(Client client);
        IEnumerable<Client> GetByUser(string user);
    }
}
