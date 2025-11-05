using FCGProj.Model;

namespace FCGProj.Interfaces.Services
{
    public interface IGameService
    {
        IEnumerable<Game> GetAll();
        Game? GetById(int id);
        void Add(Game game);
    }
}
