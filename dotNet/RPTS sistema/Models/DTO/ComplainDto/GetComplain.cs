using RPTS_sistema.Models.DTO.CompanyDto;

namespace RPTS_sistema.Models.DTO.ComplainDto
{
    public class GetComplain
    {
        public int ComplainId { get; set; }
        public string Complainant { get; set; }
        public string ComplaintDescription { get; set; }
        public GetCompany Company { get; set; }    
        /// <summary>
        /// skundo pradzioj data yra data, kuomet skundas kuriamas
        /// </summary>
        public string ComplainStartDate { get; set; }
        public string? ComplainEndDate { get; set; }
        /// <summary>
        /// Ikeliama galutine isvada, koks sprendimas priimtas
        /// </summary>
        public string? Conclusion { get; set; }
        /// <summary>
        /// Grazinamas tyrejo vardas ir pavarde
        /// </summary>
        public string Investigator { get; set; }
        /// <summary>
        /// atiduodamas tyrejo tel. numeris
        /// </summary>
    }
}
