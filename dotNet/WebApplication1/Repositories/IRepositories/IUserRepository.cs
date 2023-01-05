using ApiMokymai.Models;
using ApiMokymai.Models.Dto;
using System.Linq.Expressions;

namespace ApiMokymai.Repositories
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        User Register(RegistrationRequest registrationRequest);
        public User Get(Expression<Func<User, bool>> filter = null);
    }
}