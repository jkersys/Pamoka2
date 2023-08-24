using RPTS_sistema.Models;
using RPTS_sistema.Models.DTO.CompanyDto;
using RPTS_sistema.Models.DTO.InvestigationDto;
using RPTS_sistema.Models.DTO.InvestigationStageDto;
using RPTS_sistema.Models.DTO.InvestigatorDto;
using RPTS_sistema.Models.DTO.LocalUserDto;
using RPTS_sistema.Service.IService;

namespace RPTS_sistema.Service
{
    public class InvestigationAdapter : IInvestigationAdapter
    {
        public GetInvestigations Bind(Investigation investigation)
        {
            return new GetInvestigations()
            {
                InvestigationId = investigation.CompanyId,
                Company = investigation.Company.CompanyName,
                InvestigationStage = investigation.Stages.Select(st => new GetInvestigationStages(st)).ToList(),
                InvestigationStarted = investigation.StartDate.ToString("yyyy-MM-dd"),
                InvestigationEnded = investigation.EndDate?.ToString("yyyy-MM-dd"),
                Investigator = investigation.Investigators.Select(i => new GetLocalUserNameAndLastName(i)).ToList(),
                Conclusion = investigation.Conclusion?.Decision,
                Penalty = investigation.Penalty,
            };
        }

        public GetOneInvestigation BindForOneInvestigation(Investigation investigation)
        {
            return new GetOneInvestigation()
            {
                InvestigationId = investigation.InvestigationId,
                Company = new GetCompany(investigation.Company),
                LegalBase = investigation.LegalBase,
                InvestigationStage = investigation.Stages.Select(st => new GetInvestigationStages(st)).ToList(),
                InvestigationStarted = investigation.StartDate.ToString("yyyy-MM-dd"),
                InvestigationEnded = investigation.EndDate?.ToString("yyyy-MM-dd"),
                Investigator = investigation.Investigators.Select(i => new GetInvestigator(i)).ToList(),
                Conclusion = investigation.Conclusion?.Decision,
                IsComplained = investigation.DecisionComplained.ToString(),
                CommissionDecision = investigation.CommissionDecision,
                Penalty = investigation.Penalty,
            };
        }
    }
}
