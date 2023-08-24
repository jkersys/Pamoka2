using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models
{
    public class Investigation
    {
        public Investigation()
        {
            Stages = new List<InvestigationStage>();
            Investigators = new List<LocalUser>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvestigationId { get; set; }
        public int CompanyId { get; set; }
        public string LegalBase { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Conclusion? Conclusion { get; set; }
        public string? CommissionDecision { get; set; }
        public int? Penalty { get; set; }
        public bool DecisionComplained { get; set; } = false;
        public bool IsCompleted { get; set; } = false;
        public bool IsInvestigationDeleted { get; set; } = false;
        public ICollection<InvestigationStage>? Stages { get; set; }
        public virtual ICollection<LocalUser> Investigators { get; set; }
        public Company Company { get; set; }
    }
}

