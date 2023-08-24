using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models.DTO.InvestigationDto
{
    public class CreateInvestigation
    {
        [Required]
        public int CompanyId { get; set; }
        [Required]
        public string LegalBase { get; set; }
        [Required]
        public string InvestigationStage { get; set; }
        [Required]
        public int InvestigatorId { get; set; }
    }
}
