using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMokymai.Models
{
    public class ReaderCard
    {      

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public double? Debt { get; set; }
        public int BooksLoeanedAtm { get; set; }
        public int BooksLateToReturnAtm { get; set; }
        public virtual List<Reservation> UserBooks {get; set;}
        public virtual User User { get; set; }

    }
}
