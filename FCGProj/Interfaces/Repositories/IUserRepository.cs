using FCGProj.Models;

namespace FCGProj.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User? GetById(int id);
        User? GetByUser(string user);
        IEnumerable<User> GetListByUser(string user);
        void Add(User user);
    }
}
