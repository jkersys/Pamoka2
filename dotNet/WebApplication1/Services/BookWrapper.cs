using ApiMokymai.Models;
using ApiMokymai.Models.Dto;
using ApiMokymai.Services.IServices;

namespace ApiMokymai.Services
{
    public class BookWrapper : IBookWrapper
    { 
        public GetBookDto Bind(Book book)
        {
            return new GetBookDto {
             Id = book.Id,
             PavadinimasIrAutorius = $"{book.Title} ir {book.Author}",
             LeidybosMetai = book.PublishYear,
             Kiekis = book.Quantity            
            
            };
        }

        public Book Bind(CreateBookDto book)
        {
            return new Book
            {
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
                Quantity = book.Kiekis
            };
        }

        public Book Bind(UpdateBookDto book)
        {
            return new Book {
                Id = book.Id,
                Title = book.Pavadinimas,
                Author = book.Autorius,
                PublishYear = book.Isleista.Year,
                ECoverType = (ECoverType)Enum.Parse(typeof(ECoverType), book.KnygosTipas),
                Quantity = book.Kiekis
            };
        }
    }
}
