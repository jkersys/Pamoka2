namespace RPTS_sistema.Models.DTO.CompanyDto
{
    public class GetCompany
    {
        public GetCompany()
        {
        }

        public GetCompany(Company company)
        {
            CompanyId = company.CompanyId;
            CompanyName = company.CompanyName;
            CompanyRegistrationNumber = company.CompanyRegistrationNumber;
            CompanyFoundDate = company.CompanyFoundDate;
            CompanyCategory = company.CompanyCategory;
            CompanyAdress = company.CompanyAdress;
            CompanyEmail = company.CompanyEmail;
            CompanyPhone = company.CompanyPhone;
        }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int CompanyRegistrationNumber { get; set; }
        public DateTime CompanyFoundDate { get; set; }
        public string CompanyCategory { get; set; }
        public string CompanyAdress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
    }
}
