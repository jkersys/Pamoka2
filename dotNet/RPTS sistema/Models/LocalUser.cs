using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RPTS_sistema.Models
{
    public class LocalUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool StillWorking { get; set; } = true;
        public bool IsUserDeleted { get; set; } = false;
        public virtual ICollection<Investigation>? Investigations { get; set; }
        public virtual ICollection<AdministrativeInspection>? AdministrativeInspections { get; set; }
        public virtual ICollection<Complain>? Complains { get; set; }



    }
}
