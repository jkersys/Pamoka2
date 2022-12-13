using ApiMokymai.Models;
using ApiMokymai.Models.Dto;

namespace ApiMokymai.Repositories
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        LoginResponse Login(LoginRequest loginRequest);
        User Register(RegistrationRequest registrationRequest);
    }
}