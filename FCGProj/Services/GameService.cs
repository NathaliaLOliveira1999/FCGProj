using FCGProj.Interfaces.Repositories;
using FCGProj.Interfaces.Services;
using FCGProj.Model;

namespace FCGProj.Services
{
    public class GameService: IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IEnumerable<Game> GetAll()
        {
            return _gameRepository.GetAll();
        }

        public Game? GetById(int id)
        {
            return _gameRepository.GetById(id);
        }

        public void Add(Game game)
        {
            _gameRepository.Add(game);
        }
    }
}