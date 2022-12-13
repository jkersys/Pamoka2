using ApiMokymai.Data;
using ApiMokymai.Models;
using ApiMokymai.Repositories;
using ApiMokymai.Repositories.IRepositories;
using ApiMokymai.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookLibraryController : ControllerBase
    {
        private readonly IBookWrapper _wrapper;
        private readonly ILogger<BookController> _logger;
        private readonly IBookRepository _repository;
        private readonly ILibraryRepository _libraryrepository;



        public BookLibraryController(IBookWrapper wraper, ILogger<BookController> logger, IBookRepository repository, ILibraryRepository libraryrepository)
        {
            _wrapper = wraper;
            _logger = logger;
            _repository = repository;
            _libraryrepository = libraryrepository;
        }

        /// <summary>
        /// Irasomas automobilis i duomenu baze
        /// </summary>
        /// <returns></returns>
        /// <response code="400">paduodamos informacijos validacijos klaidos </response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Post(Book req)
        {
            var libraryBook = _libraryBookRepo.Get(b => b.Id == createUserBookDto.LibraryBookId);

            //var entity = _adapter.Bind(req);
            var id = _repository.Create(entity);

            return Created("PostCar", new { Id = id });
        }
    }
}
