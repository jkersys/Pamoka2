using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Database;
using RPTS_sistema.Models;
using RPTS_sistema.Repository.IRepository;

namespace RPTS_sistema.Repository
{
    public class ConclusionRepository : Repository<Conclusion>, IConclusionRepository
    {
        private readonly RptsContext _db;
        public ConclusionRepository(RptsContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Conclusion> GetConclusionById(int id)
        {
            var conclusion = await _db.Conclusion.Include(x => x.Complains).Include(x => x.AdministrativeInspections)
                .Include(x => x.Investigations).FirstOrDefaultAsync(x => x.ConclusionId == id);
            return conclusion;
        }
    }
}
