using RPTS_sistema.Database;
using RPTS_sistema.Models;
using RPTS_sistema.Repository.IRepository;

namespace RPTS_sistema.Repository
{
    public class ComplainRepository : Repository<Complain>, IComplainRepository
    {
        private readonly RptsContext _db;
        public ComplainRepository(RptsContext db) : base(db)
        {
            _db = db;
        }
    }
}
