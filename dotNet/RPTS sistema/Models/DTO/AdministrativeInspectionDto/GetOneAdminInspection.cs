using RPTS_sistema.Models.DTO.CompanyDto;
using RPTS_sistema.Models.DTO.InvestigationStageDto;
using RPTS_sistema.Models.DTO.InvestigatorDto;

namespace RPTS_sistema.Models.DTO.AdministrativeInspectionDto
{
    public class GetOneAdminInspection
    {
        public string StartDate { get; set; }
        public string? EndDate { get; set; }
        public ICollection<GetInvestigationStages> InvestigationStages { get; set; }
        public GetCompany Company { get; set; }
        public ICollection<GetInvestigator> Investigators { get; set; }
        public string? Conclusion { get; set; }
    }
}
