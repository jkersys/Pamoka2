using Microsoft.EntityFrameworkCore;
using RPTS_sistema.Database;
using RPTS_sistema.Models;
using RPTS_sistema.Repository.IRepository;

namespace RPTS_sistema.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
    
        private readonly RptsContext _db;

        public CompanyRepository(RptsContext db) : base(db)
        {
            _db = db;

        }
        public async Task<Company> GetCompanyById(int id)
        {
            var company = await _db.Company.FirstOrDefaultAsync(x => x.CompanyId == id);
            return company;
        }
    }
}
