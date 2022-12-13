using ApiMokymai.Models;
using ApiMokymai.Models.Dto;
using ApiMokymai.Services.IServices;

namespace ApiMokymai.Services
{
    public class BookManager : IBookManager
    {
        private readonly IBookSet _context;
        private readonly IBookWrapper _wrapper;
        public BookManager(IBookSet context, IBookWrapper wrapper)
        {
            _context = context;
            _wrapper = wrapper;
        }

        public List<GetBookDto> Get()
        {
            var sarasas = _context.Books;
            var dto = sarasas.Select(s => _wrapper.Bind(s)).ToList();
            return dto;
        }
        public GetBookDto Get(int id) => Exists(id) ? _wrapper.Bind(_context.Books.Where(b => b.Id == id).FirstOrDefault()) : throw new Exception();

        public bool Exists(int id) => _context.Books.Where(b => b.Id == id).Any() ? true : false;

        public List<GetBookDto> Filter(Dictionary<string, string> filter)
        {
            IEnumerable<Book> books = _context.Books;
            foreach (var item in filter)
            {
                if (item.Key == "Pavadinimas") books = books.Where(b => b.Title.ToLower() == item.Value.ToLower());
                if (item.Key == "Autorius") books = books.Where(b => b.Author.ToLower() == item.Value.ToLower());
                if (item.Key == "KnygosTipas") books = books.Where(b => (int)b.ECoverType == int.Parse(item.Value));
            }
            return books.Select(b => _wrapper.Bind(b)).ToList();
        }

        public int Add(CreateBookDto book)
        {
            var bookToAdd = _wrapper.Bind(book);
            _context.Books.Add(bookToAdd);
            return bookToAdd.Id;
        }

        public void Update(UpdateBookDto book)
        {
            var bookToUpdate = _context.Books.Find(b => b.Id == book.Id);
            bookToUpdate = _wrapper.Bind(book);
        }

        public void Delete(int id)
        {
            if (Exists(id))
                _context.Books.Remove(_context.Books.Where(b => b.Id == id).FirstOrDefault());
        }
    }
}