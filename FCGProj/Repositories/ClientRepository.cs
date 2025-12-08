using FCGProj.Interfaces.Repositories;
using FCGProj.Model;
using FCGProj.Models;
using Microsoft.EntityFrameworkCore;

namespace FCGProj.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAll() => _context.Clients.ToList();

        public Client? GetById(int id) => _context.Clients.Find(id);

        public void Add(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public IEnumerable<Client> GetByUser(string user)
        {
            var result = _context.Clients.Where(x => x.ClientUser == user.ToUpper()).ToList();

            return result ?? Enumerable.Empty<Client>();
        }
    }
}
