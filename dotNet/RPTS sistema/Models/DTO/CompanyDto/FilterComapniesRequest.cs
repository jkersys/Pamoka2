namespace RPTS_sistema.Models.DTO.CompanyDto
{
    public class FilterComapniesRequest
    {
        public string? CompanyName { get; set; }
        public int CompanyRegistrationNumber { get; set; }
        public DateTime CompanyFoundDate { get; set; } 
        public string? CompanyCategory { get; set; }
    }
}
