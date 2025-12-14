using FCGProj.Models;

namespace FCGProj.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User? GetById(int id);
        User? GetByUser(string user);
        IEnumerable<User> GetListByUser(string user);
        ServiceResult Add(User user, int idCliente);
    }
}
