using ApiMokymai.Models;
using ApiMokymai.Services.IServices;

namespace ApiMokymai.Services
{
    public class ReservationValidator : IReservationValidator
    {
        public bool CanBookBeReserved(Book book)
        {
            if (book.Quantity > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool CanUserReservBook(ReaderCard readerCard)
        {
            var canLoan = false;
           
            var booksLoaned = readerCard.UserBooks.Where(x => x.Returned == false).ToList().Count();
            var booksLateToReturn = readerCard.UserBooks.Where(x => x.Returned == false)
                .Where(x => x.BorrowDate = ); //gal pasidaryt is karto imant knyga actual return date ir numatoma return date

          //  var date = DateTime.Now;
           // var add date.AddMonths(1)

            if (booksLoaned >= 5)
            {
                return false;
            }


            return canLoan;
        }
        
    }
}
