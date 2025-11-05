using FCGProj.Model;

namespace FCGProj.Interfaces.Repositories
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAll();
        Game? GetById(int id);
        void Add(Game game);
    }
}
