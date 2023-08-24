namespace RPTS_sistema.Models.DTO.AdministrativeInspectionDto
{
    public class CreateAdminInspection
    {
        public string InvestigationStage { get; set; }
        public int CompanyId { get; set; }
        public int InvestigatorId { get; set; }

    }
}
