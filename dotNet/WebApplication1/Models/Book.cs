using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMokymai.Models
{
    public class Book
    {
        public Book()
        {
        }

        public Book(int id, string title, string author, ECoverType eCoverType, int publishYear, int quantity)
        {
            Id = id;
            Title = title;
            Author = author;
            ECoverType = eCoverType;
            PublishYear = publishYear;
            Quantity = quantity;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public ECoverType ECoverType { get; set; }
        public int PublishYear { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public int Quantity { get; set; }
}
}
