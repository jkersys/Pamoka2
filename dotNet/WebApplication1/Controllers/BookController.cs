using ApiMokymai.Data;
using ApiMokymai.Models;
using ApiMokymai.Models.Dto;
using ApiMokymai.Repositories.IRepositories;
using ApiMokymai.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //vienas kontroleris +
    //keturi dto +
    //vienas wrapperis +
    //vienas repozitorius 
    //vienas dbcontext +




    public class BookController : ControllerBase
    {

        private readonly BookContext _context;
        private readonly IBookWrapper _wrapper;
        private readonly ILogger<BookController> _logger;
        private readonly IBookRepository _repository;



        public BookController(BookContext context, IBookWrapper wraper, ILogger<BookController> logger, IBookRepository repository)
        {
            _wrapper = wraper;
            _context = context;
            _logger = logger;
            _repository = repository;
        }



        [HttpGet]
        [Authorize]
        public ActionResult<List<GetBookDto>> Get()
        {
         return Ok(_repository.GetAll().Select(book => _wrapper.Bind(book))
                    .ToList());
        }
        [HttpGet("books/{id:int}")]
        public ActionResult<GetBookDto> GetBookById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            // Tam, kad istraukti duomenis naudokite
            // First, FirstOrDefault, Single, SingleOrDefault, ToList
            var book = _repository.Get(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(_wrapper.Bind(book));
        }
        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> Filter([FromQuery]FilterBookRequest req)
        {
            throw new NotImplementedException();
        }
        [HttpPost("createBook")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(IEnumerable<CreateBookDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces(MediaTypeNames.Application.Json)]
        public ActionResult<CreateBookDto> CreateBook(CreateBookDto req)
        {
            if (!Enum.TryParse(typeof(ECoverType), req.KnygosTipas, out _))
            {
                var validValues = Enum.GetNames(typeof(ECoverType));
                ModelState.AddModelError(nameof(req.KnygosTipas), $"Not valid value. Valid values are: {string.Join(", ", validValues)}");
            }         

            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            Book book = _wrapper.Bind(req);
            _repository.Create(book);
            

            return Created("PostBook", new { Id = book.Id});
        }
        [HttpPut("upadteBook")]
        public ActionResult UpdateBook(UpdateBookDto req)
        {
            Book book = _wrapper.Bind(req);
            _repository.Update(book);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var bookById = _repository.Get(b => b.Id == id);
            _repository.Remove(bookById);

            return NoContent();
        }
    }
}


