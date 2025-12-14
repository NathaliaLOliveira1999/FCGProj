using FCGProj.Model;
using FCGProj.Models;

namespace FCGProj.Interfaces.Repositories
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAll();
        Client? GetById(int id);
        ServiceResult Add(Client client);
        IEnumerable<Client> GetListByEmail(string email);
    }
}
