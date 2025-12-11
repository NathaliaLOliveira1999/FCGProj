using FCGProj.Interfaces.Repositories;
using FCGProj.Models;

namespace FCGProj.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User? GetById(int id) => _context.Users.Find(id);

        public User? GetByUser(string user)
        {
            return _context.Users.Where(x => x.UserName == user.ToUpper()).FirstOrDefault();
        }

        public IEnumerable<User> GetListByUser(string user)
        {
            var result = _context.Users.Where(x => x.UserName == user.ToUpper()).ToList();

            return result ?? Enumerable.Empty<User>();
        }

        public void Add(User user)
        {
            user.CreatedAt = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}