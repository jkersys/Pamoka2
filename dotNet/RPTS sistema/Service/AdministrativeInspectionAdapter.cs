using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.AdministrativeInspectionDto;
using RPTS_sistema.Models.DTO.CompanyDto;
using RPTS_sistema.Models.DTO.InvestigationStageDto;
using RPTS_sistema.Models.DTO.InvestigatorDto;
using RPTS_sistema.Models.DTO.LocalUserDto;
using RPTS_sistema.Service.IService;

namespace RPTS_sistema.Service
{
    public class AdministrativeInspectionAdapter : IAdministrativeInspectionAdapter
    {
        public GetAdminInspections Bind(AdministrativeInspection inspection)
        {
            return new GetAdminInspections()
            {
                Id = inspection.AdministrativeInspectionId,
                StartDate = inspection.StartDate.ToString("yyyy-MM-dd"),
                EndDate = inspection.EndDate?.ToString("yyyy-MM-dd"),
                InvestigationStages = inspection.InvestigationStages.Select(i => new GetInvestigationStages(i)).ToList(),
                Company = inspection.Company.CompanyName,
                Investigators = inspection.Investigators.Select(i => new GetLocalUserNameAndLastName(i)).ToList(),
                Conclusion = inspection.Conclusion?.Decision,
            };
        }

        public GetOneAdminInspection BindOneInspection(AdministrativeInspection inspection)
        {
            return new GetOneAdminInspection()
            {
                StartDate = inspection.StartDate.ToString("yyyy-MM-dd"),
                EndDate = inspection.EndDate?.ToString("yyyy-MM-dd"),
                InvestigationStages = inspection.InvestigationStages.Select(st => new GetInvestigationStages(st)).ToList(),
                Company = new GetCompany(inspection.Company),
                Investigators = inspection.Investigators.Select(i => new GetInvestigator(i)).ToList(),
                Conclusion = inspection.Conclusion?.Decision,

            };
        }
    }
}
