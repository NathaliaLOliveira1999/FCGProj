using FCGProj.Model;
using FCGProj.Models;
using FCGProj.Models.Dto;

namespace FCGProj.Interfaces.Services
{
    public interface IClientService
    {
        IEnumerable<Client> GetAll();
        ClientDto? GetById(int id);
        ServiceResult Add(ClientDto client);
    }
}
