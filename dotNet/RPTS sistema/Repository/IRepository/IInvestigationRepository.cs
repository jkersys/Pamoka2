using RPTS_sistema.Models;

namespace RPTS_sistema.Repository.IRepository
{
    public interface IInvestigationRepository : IRepository<Investigation>
    {
        Task<Investigation> GetById(int id);
        Task<IEnumerable<Investigation>> All();
    }
}
