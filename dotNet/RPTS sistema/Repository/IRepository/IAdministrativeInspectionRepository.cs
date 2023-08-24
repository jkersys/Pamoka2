using RPTS_sistema.Models;

namespace RPTS_sistema.Repository.IRepository
{
    public interface IAdministrativeInspectionRepository : IRepository<AdministrativeInspection>
    {
        Task<IEnumerable<AdministrativeInspection>> LoggedUserAdministrativeInspecitons();
        Task<AdministrativeInspection> GetById(int id);
    }
}
