using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMokymai.Models
{
    public class ReaderCard
    {
        private int _borrowedBooks;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int BorrowedBooksCount { get { return _borrowedBooks; } set { _borrowedBooks = BorrowedBooks.Count(); } }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BooksLateToReturn { get; set; }
        public double Debt { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public virtual IEnumerable<Book> BorrowedBooks {get; set;}
        public virtual User User { get; set; }

    }
}
