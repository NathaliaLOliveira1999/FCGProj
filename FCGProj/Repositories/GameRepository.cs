using FCGProj.Interfaces.Repositories;
using FCGProj.Model;
using FCGProj.Models;

namespace FCGProj.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _context;

        public GameRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Game> GetAll() => _context.Games.ToList();

        public Game? GetById(int id) => _context.Games.Find(id);

        public void Add(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
        }
    }
}

