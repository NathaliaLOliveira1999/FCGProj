using FCGProj.Interfaces.Services;
using FCGProj.Model;
using FCGProj.Models;
using FCGProj.Models.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FCGProj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll() => Ok(_clientService.GetAll());

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Client = _clientService.GetById(id);
            if (Client == null)
                return NotFound();
            return Ok(Client);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(ClientDto client)
        {
            if (client == null)
                return BadRequest("Preencha as informações do usuário!");
            var retorno = _clientService.Add(client);
            if (retorno.Success)
                return Ok();
            else return BadRequest(retorno.Error);
        }
    }
}