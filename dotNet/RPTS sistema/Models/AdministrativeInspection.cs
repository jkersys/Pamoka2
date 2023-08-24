using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models
{
    public class AdministrativeInspection
    {
        public AdministrativeInspection()
        {
            InvestigationStages = new List<InvestigationStage>();
            Investigators = new List<LocalUser>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdministrativeInspectionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool InspectionDeleted { get; set; } = false;
        public bool IsCompleted { get; set; } = false;
        public ICollection<InvestigationStage> InvestigationStages { get; set; }
        public Company Company { get; set; }
        public ICollection<LocalUser> Investigators { get; set; }
        public Conclusion? Conclusion { get; set; }
    }
}
