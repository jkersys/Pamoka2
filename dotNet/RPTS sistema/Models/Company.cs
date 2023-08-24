using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }        
        public int CompanyRegistrationNumber { get; set; }
        public DateTime CompanyFoundDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCategory { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public bool IsCompanyDeleted { get; set; } = false;
        public ICollection<Investigation> Investigations { get; set; }
        public ICollection<AdministrativeInspection> AdministrativeInspections { get; set; }
        public ICollection<Complain> Complain { get; set; }

    }
}