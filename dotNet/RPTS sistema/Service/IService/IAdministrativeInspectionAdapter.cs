using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.AdministrativeInspectionDto;

namespace RPTS_sistema.Service.IService
{
    public interface IAdministrativeInspectionAdapter
    {
        GetAdminInspections Bind(AdministrativeInspection inspection);
        GetOneAdminInspection BindOneInspection(AdministrativeInspection inspection);
    }
}
