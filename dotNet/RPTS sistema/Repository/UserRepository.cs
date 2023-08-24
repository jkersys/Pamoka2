using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Database;
using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.LocalUserDto;
using RPTS_sistema.Repository.IRepository;
using RPTS_sistema.Service;
using RPTS_sistema.Service.IService;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace RPTS_sistema.Repository
{
    public class UserRepository : Repository<LocalUser>, IUserRepository
    {
        private readonly RptsContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserRepository(RptsContext db, IPasswordService passwordService, IJwtService jwtService, IHttpContextAccessor httpContextAccessor) : base(db)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService = jwtService;
            _httpContextAccessor = httpContextAccessor;
        }


        public async Task<LocalUser> GetUserById(int id)
        {
            return await _db.LocalUser.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<LocalUser>> All()
        {
            var users = await _db.LocalUser.ToListAsync();
            return users;
        }

        public async Task<bool> IsUniqueUserAsync(string email)
        {
            var user = await _db.LocalUser.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var inputPasswordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = await _db.LocalUser.FirstOrDefaultAsync(x => x.Email.ToLower() == loginRequest.Email.ToLower());

            if (user == null || !_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt))
            {
                return new LoginResponse
                {
                    Token = "",
                    Email = null
                };
            }

            var token = _jwtService.GetJwtToken(user.Id, user.Role.ToString());

            LoginResponse loginResponse = new()
            {
                Token = token,
                Email = user.Email
            };

            return loginResponse;
        }

        public async Task<LocalUser> RegisterAsync(RegistrationRequest registrationRequest)
        {
            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);

            LocalUser user = new()
            {
                Email = registrationRequest.Email,
                Name = registrationRequest.Name,
                Lastname = registrationRequest.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };

            _db.LocalUser.Add(user);
            await _db.SaveChangesAsync();
            user.PasswordHash = null;
            return user;
        }
    

    public async Task<string> ChangePasswordAsync(LocalUser user, ChangePassword changePassword)
    {
            _passwordService.CreatePasswordHash(changePassword.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _db.LocalUser.Update(user);
            await _db.SaveChangesAsync();
            user.PasswordHash = null;
            return user.Email;
    }
}
}
