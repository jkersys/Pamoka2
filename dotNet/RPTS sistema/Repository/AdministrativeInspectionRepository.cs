using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Database;
using RPTS_sistema.Models;
using RPTS_sistema.Repository.IRepository;
using System.Security.Claims;

namespace RPTS_sistema.Repository
{
    public class AdministrativeInspectionRepository : Repository<AdministrativeInspection>, IAdministrativeInspectionRepository
    {
        private readonly RptsContext _db;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdministrativeInspectionRepository(RptsContext db, IHttpContextAccessor httpContextAccessor) : base(db)
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<AdministrativeInspection> GetById(int id)
        {
            var adminInspection = await _db.AdministrativeInspections.Include(x => x.Investigators).Include(x => x.Conclusion).Include(x => x.Company).Include(x => x.InvestigationStages).FirstOrDefaultAsync(x => x.AdministrativeInspectionId == id);
            return adminInspection;
        }

        public async Task<IEnumerable<AdministrativeInspection>> LoggedUserAdministrativeInspecitons()
        {
            //var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);
           // var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
           // if (currentUserRole == "Admin" || currentUserRole == "Director")
            //{
                return await _db.AdministrativeInspections.Include(x => x.Investigators).Include(x => x.Conclusion).Include(x => x.Company).Include(x => x.InvestigationStages).ToListAsync();

           // }
          //  else
                //return _db.AdministrativeInspections.Include(x => x.Investigators).Include(x => x.Conclusion)
                //       .Include(x => x.Company).Include(x => x.InvestigationStages)
                //       .Where(x => x.Investigators.Any(x => x.Id == currentUserId));
        }
    }
}
