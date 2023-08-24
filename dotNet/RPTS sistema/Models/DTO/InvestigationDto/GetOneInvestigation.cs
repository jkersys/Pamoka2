using RPTS_sistema.Models.DTO.CompanyDto;
using RPTS_sistema.Models.DTO.InvestigationSatge;
using RPTS_sistema.Models.DTO.InvestigationStageDto;
using RPTS_sistema.Models.DTO.InvestigatorDto;
using RPTS_sistema.Models.DTO.LocalUserDto;

namespace RPTS_sistema.Models.DTO.InvestigationDto
{
    public class GetOneInvestigation
    {
        public int InvestigationId { get; set; }
        /// <summary>
        /// grazinama visa imones, kurios atzvilgiu vykdomas tyrimas informacija
        /// </summary>
        public GetCompany Company { get; set; }
        public string LegalBase { get; set; }
        /// <summary>
        /// tyrimo etapu sarasas, su etapo data ir aprasymu
        /// </summary>
        public ICollection<GetInvestigationStages>? InvestigationStage { get; set; }
        public string InvestigationStarted { get; set; }
        public string? InvestigationEnded { get; set; }
        public string? Conclusion { get; set; }
        public string? CommissionDecision { get; set; }
        public string? IsComplained { get; set; }
        public ICollection<GetInvestigator> Investigator { get; set; }
        public int? Penalty { get; set; }
    }
}
