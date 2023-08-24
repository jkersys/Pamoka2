namespace RPTS_sistema.Models.DTO.ComplainDto
{
    public class CreateComplain
    {
        /// <summary>
        /// nurodoma skundo aplinkybes
        /// </summary>
        public string Description { get; set; }
        public string Complainant { get; set; }
        public DateTime ComplainDate { get; set; }
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Nurodoma visa zinoma informacija apie skundziama imone
        /// </summary>
        public int CompanyId { get; set; }
        public int ConclusionId { get; set; }

    }
}
