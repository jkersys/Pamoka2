using RPTS_sistema.Models.DTO.InvestigationStageDto;
using RPTS_sistema.Models.DTO.LocalUserDto;

namespace RPTS_sistema.Models.DTO.AdministrativeInspectionDto
{
    public class GetAdminInspections
    {
        public int Id { get; set; }
        public string StartDate { get; set; }
        public string? EndDate { get; set; }
        public ICollection<GetInvestigationStages>? InvestigationStages { get; set; }
        public string Company { get; set; }
        public ICollection<GetLocalUserNameAndLastName> Investigators { get; set; }
        public string? Conclusion { get; set; }
    }
}
