using FCGProj.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FCGProj.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly IConfiguration _config;

        public AuthorizationController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto login)
        {
            // 1️⃣ Buscar usuário pelo e-mail
            //var user = await _context.Users
            //    .FirstOrDefaultAsync(x => x.ClientUser == login.ClientUser);

            //if (user == null)
            //    return Unauthorized("Usuário não encontrado");

            //// 2️⃣ Validar senha com hash
            //if (!BCrypt.Net.BCrypt.Verify(login.Password, user.PasswordHash))
            //    return Unauthorized("Senha incorreta");

            //// 3️⃣ Gerar token JWT
            //var token = GenerateToken(user);

            //return Ok(new { token });
            return Ok();
        }
    }
}
