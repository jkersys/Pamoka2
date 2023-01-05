namespace CarApiAiskinimas.Models
{
    public class UserPersonalData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonalCode { get; set; }

        public virtual LocalUser LocalUser { get; set; }

    }
}
