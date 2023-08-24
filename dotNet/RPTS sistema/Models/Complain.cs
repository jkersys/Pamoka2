using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models
{
    public class Complain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComplainId { get; set; }
        public int CompanyId { get; set; }
        [Required]
        public string Description { get; set; }
        public string Complainant { get; set; }
        [Required]
        public DateTime ComplainDate { get; set; }
        public DateTime? DecisionDate { get; set; }
        public bool IsComplainDeleted { get; set; } = false;
        public Conclusion? Conclusion { get; set; }
        public LocalUser? Investigator { get; set; }
        public Company Company { get; set; }
    }
}
