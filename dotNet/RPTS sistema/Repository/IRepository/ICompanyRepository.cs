using RPTS_sistema.Models;

namespace RPTS_sistema.Repository.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Task<Company> GetCompanyById(int id);
    }
}
