namespace RPTS_sistema.Models.DTO.InvestigationDto
{
    public class FilterInvestigationRequest
    {
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? InvestigatorName { get; set; }
        public string? InvestigatorLastname { get; set; }
        public string? InvestigationConlusion { get; set; }
        public string? ComsisionDecision { get; set; }
        public string? IsCompleted { get; set; }
        public string? IsComplained { get; set; }
    }
}
