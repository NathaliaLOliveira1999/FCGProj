using FCGProj.Model;
using FCGProj.Models;

namespace FCGProj.Interfaces.Services
{
    public interface IClientService
    {
        IEnumerable<Client> GetAll();
        Client? GetById(int id);
        ServiceResult Add(ClientDTO client);
    }
}
