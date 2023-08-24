using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.LocalUserDto;
using System.Linq.Expressions;

namespace RPTS_sistema.Repository.IRepository
{
    public interface IUserRepository : IRepository<LocalUser>
    {
        Task<bool> IsUniqueUserAsync(string email);
        Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
        Task<LocalUser> RegisterAsync(RegistrationRequest registrationRequest);
        Task<LocalUser> GetUserById(int id);
        Task<string> ChangePasswordAsync(LocalUser user, ChangePassword changePassword);
        Task<IEnumerable<LocalUser>> All();
    }
}
