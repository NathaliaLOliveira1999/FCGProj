using FCGProj.Interfaces.Repositories;
using FCGProj.Model;
using FCGProj.Models;

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
            client.DtCreate = DateTime.Now;
            _context.Clients.Add(client);
            _context.SaveChanges();
        }
    }
}
