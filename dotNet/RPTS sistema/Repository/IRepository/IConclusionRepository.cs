using RPTS_sistema.Models;

namespace RPTS_sistema.Repository.IRepository
{
    public interface IConclusionRepository : IRepository<Conclusion>
    {
        Task<Conclusion> GetConclusionById(int id);
    }
}
