namespace RPTS_sistema.Models.DTO.LocalUserDto
{
    public class UsersForFEWithStatistic
    {
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int? AllInvestigations { get; set; }
        public int? FinishedInvestigations { get; set; }
        public int? ActiveInvestigations { get; set; }
        public int? AllInspections { get; set; }
        public int? FinishedInspections { get; set; }
        public int? ActiveInspections { get; set; }
    }
}
