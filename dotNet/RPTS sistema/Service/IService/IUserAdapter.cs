using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.LocalUserDto;

namespace RPTS_sistema.Service.IService
{
    public interface IUserAdapter
    {
        GetUsersForFrontEnd Bind(LocalUser user);
        UsersForFEWithStatistic BindStatistic(LocalUser user);
    }
}
