using ApiMokymai.Models;

namespace ApiMokymai.Services.IServices
{
    public interface IReservationValidator
    {
        bool CanBookBeReserved(Book book);
        bool CanUserReservBook(ReaderCard readerCard);
    }
}