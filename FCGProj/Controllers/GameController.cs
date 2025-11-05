using FCGProj.Interfaces.Services;
using FCGProj.Model;
using FCGProj.Services;
using Microsoft.AspNetCore.Mvc;

namespace FCGProj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_gameService.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Client = _gameService.GetById(id);
            if (Client == null)
                return NotFound();
            return Ok(Client);
        }

        [HttpPost]
        public IActionResult Create(Game game)
        {
            _gameService.Add(game);
            return CreatedAtAction(nameof(GetById), new { id = game.IdGames }, game);
        }
    }
}