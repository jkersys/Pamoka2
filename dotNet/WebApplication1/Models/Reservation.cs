using System.ComponentModel.DataAnnotations;

namespace ApiMokymai.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int ReaderCardId { get; set; }        
        public int BookId { get; set; }        
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool Returned { get; set; } = false;
        //virtual public Book Book { get; set; } //uzdisablinau, nes traukiant revzervacija pagal id pirma traukia knyga.
    }
}
