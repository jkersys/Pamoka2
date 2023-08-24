using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models
{
    public class Conclusion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConclusionId { get; set; }
        public string Decision { get; set; }
        public bool IsConclusionDeleted { get; set; }
        public ICollection<Complain>? Complains { get; set; }
        public ICollection<AdministrativeInspection>? AdministrativeInspections { get; set; }
        public ICollection<Investigation>? Investigations { get; set; }
    }
}