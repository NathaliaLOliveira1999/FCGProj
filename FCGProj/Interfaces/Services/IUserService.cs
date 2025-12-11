using FCGProj.Models;
using FCGProj.Models.Dto;

namespace FCGProj.Interfaces.Services
{
    public interface IUserService
    {
        UserDto? GetById(int id);
        UserDto? GetByUser(string user);
        List<UserDto> GetListByUser(string user);
        ServiceResult Add(UserDto user);
        string GenerateToken(UserDto user);
    }
}
