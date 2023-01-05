using ApiMokymai.Data;
using ApiMokymai.Models;
using ApiMokymai.Models.Dto;
using ApiMokymai.Repositories.IRepositories;
using ApiMokymai.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Text;

namespace ApiMokymai.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;

        public UserRepository(BookContext db, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService = jwtService;
        }

        /// <summary>
        /// Should return a flag indicating if a user with a specified username already exists
        /// </summary>
        /// <param name="username">Registration username</param>
        /// <returns>A flag indicating if username already exists</returns>
        public bool IsUniqueUser(string username)
        {
            var user = _db.Users.FirstOrDefault(x => x.Username == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public LoginResponse Login(LoginRequest loginRequest)
        {
            var inputPasswordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = _db.Users.FirstOrDefault(x => x.Username.ToLower() == loginRequest.Username.ToLower());

            if (user == null && !_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt))
            {
                return new LoginResponse
                {
                    Token = "",
                    User = null
                };
            }

            var token = _jwtService.GetJwtToken(user.Id, user.Name);

            LoginResponse loginResponse = new()
            {
                Token = token,
                User = user
            };

            loginResponse.User.PasswordHash = null;

            return loginResponse;
        }

        // Add RegistrationResponse (Should not include password)
        // Add adapter classes to map to wanted classes
        public User Register(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);

       
            User user = new()
                {
                    Username = registrationRequest.Username,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Name = registrationRequest.Name,
                    //Role = registrationRequest.Role,
                    Role = _db.UserRole.First(x => x.Name == registrationRequest.Role),
                    UserReaderCard = new ReaderCard(),
                    
                };

            _db.Users.Add(user);
            _db.SaveChanges();
            user.PasswordHash = null;
            return user;
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
           return _db.Users.FirstOrDefault(filter);
        }
    }
}
   