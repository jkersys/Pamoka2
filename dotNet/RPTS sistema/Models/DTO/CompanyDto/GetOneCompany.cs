namespace RPTS_sistema.Models.DTO.CompanyDto
{
    public class GetOneCompany
    {
        public int CompanyId { get; set; }
        public int CompanyRegistrationNumber { get; set; }
        public DateTime CompanyFoundDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCategory { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public ICollection<Investigation> Investigations { get; set; }
        public ICollection<AdministrativeInspection> AdministrativeInspections { get; set; }
        public ICollection<Complain> Complain { get; set; }
    }
}
