using RPTS_sistema.Models.DTO.InvestigationSatge;
using RPTS_sistema.Models.DTO.InvestigationStageDto;
using RPTS_sistema.Models.DTO.LocalUserDto;

namespace RPTS_sistema.Models.DTO.InvestigationDto
{
    public class GetInvestigations
    {
        public int InvestigationId { get; set; }
        /// <summary>
        /// Imones, kurios atzvilgiu vykdomas tyrimas
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// tyrimo etapu sarasas, su etapo data ir aprasymu
        /// </summary>
        public ICollection<GetInvestigationStages>? InvestigationStage { get; set; }
        public string InvestigationStarted { get; set; }
        public string? InvestigationEnded { get; set; }
        public string? IsComplained { get; set; }
        public string? Conclusion { get; set; }
        public ICollection<GetLocalUserNameAndLastName> Investigator { get; set; }
        public int? Penalty { get; set; }
    }
}
