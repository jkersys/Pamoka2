﻿using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Database;
using RPTS_sistema.Models;
using RPTS_sistema.Repository.IRepository;
using System.Security.Claims;

namespace RPTS_sistema.Repository
{
    public class InvestigationRepository : Repository<Investigation>, IInvestigationRepository
    {
    private readonly RptsContext _db;
    private readonly IHttpContextAccessor _httpContextAccessor;

        public InvestigationRepository(RptsContext db, IHttpContextAccessor httpContextAccessor) : base(db)
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IEnumerable<Investigation>> All()
        {
            //var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.Identity.Name);
           // var currentUserRole = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Role);
            //if (currentUserRole == "Admin" || currentUserRole == "Director")
           // {
                return await _db.Investigation.Include(x => x.Conclusion).Include(x => x.Stages).Include(x => x.Investigators).Include(x => x.Company).Where(x => x.IsInvestigationDeleted == false).ToListAsync();

           // }
           // else
              //  return _db.Investigation.Include(x => x.Conclusion).Include(x => x.Stages).Include(x => x.Investigators)
             //       .Include(x => x.Company)
                 //      .Where(x => x.Investigators.Any(x => x.Id == currentUserId));
        }

        public async Task<Investigation> GetById(int id)
        {
            var investigation = await _db.Investigation.Include(x => x.Conclusion).Include(x => x.Stages).Include(x => x.Investigators)
                    .Include(x => x.Company).FirstOrDefaultAsync(x => x.InvestigationId == id);
            return investigation;
        }

    }
}
