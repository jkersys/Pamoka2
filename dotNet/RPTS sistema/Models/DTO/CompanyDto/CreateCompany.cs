using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models.DTO.CompanyDto
{
    public class CreateCompany
    {
        [Required]
        public int CompanyRegistrationNumber { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public DateTime CompanyFoundDate { get; set; }
        [Required]
        public string CompanyCategory { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
    
    }
}
