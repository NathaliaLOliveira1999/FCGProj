using FCGProj.Models;
using FCGProj.Models.Dto;

namespace FCGProj.Interfaces.Services
{
    public interface IUserService
    {
        UserDto? GetById(int id);
        UserDto? GetByUser(string user);
        List<UserDto> GetListByUser(string user);
        ServiceResult Add(UserDto user, int idCliente);
        string GenerateToken(UserDto user);
    }
}
