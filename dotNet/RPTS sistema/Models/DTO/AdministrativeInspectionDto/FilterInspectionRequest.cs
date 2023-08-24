namespace RPTS_sistema.Models.DTO.AdministrativeInspectionDto
{
    public class FilterInspectionRequest
    {
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? InvestigatorName { get; set; }
        public string? InvestigatorLastname { get; set; }
        public string? Conlusion { get; set; }
        public string? IsCompleted { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
