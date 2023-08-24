using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.InvestigationDto;

namespace RPTS_sistema.Service.IService
{
    public interface IInvestigationAdapter
    {
        GetInvestigations Bind(Investigation investigation);
        GetOneInvestigation BindForOneInvestigation(Investigation investigation);
    }
}
