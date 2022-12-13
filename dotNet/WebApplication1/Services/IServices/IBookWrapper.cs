using ApiMokymai.Models;
using ApiMokymai.Models.Dto;

namespace ApiMokymai.Services.IServices
{
    public interface IBookWrapper
    {
        public GetBookDto Bind(Book book);
        public Book Bind(CreateBookDto book);
        public Book Bind(UpdateBookDto book);

    }
}
