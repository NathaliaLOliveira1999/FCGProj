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

        public async Task<IEnumerable<Client>> GetByUserAsync(string user)
        {
            if (string.IsNullOrWhiteSpace(user)) return Enumerable.Empty<Client>();
            var normalized = user.Trim().ToLowerInvariant();

            return await _context.Clients
                .Where(x => !string.IsNullOrEmpty(x.ClientUser) && x.ClientUser.ToLower().Contains(normalized))
                .ToListAsync();
        }
    }
}
