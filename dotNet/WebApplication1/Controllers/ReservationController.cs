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
    public class ReservationController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookRepository _repository;
        private readonly IReservationRepository _reservationRepository;
        private readonly IUserRepository _userepository;
        private readonly IReservationValidator _reservationValidator;
        private readonly IReaderCardRepository _readerCardRepository;



        public ReservationController(ILogger<BookController> logger, IBookRepository repository, IReservationRepository reservationRepository, IUserRepository userepository, IReservationValidator reservationValidator, IReaderCardRepository readerCardRepository)
        {
            _logger = logger;
            _repository = repository;
            _reservationRepository = reservationRepository;
            _userepository = userepository;
            _reservationValidator = reservationValidator;
            _readerCardRepository = readerCardRepository;
        }
        [HttpGet("ReturnLibraryBook/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult<Reservation> GetReservationById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            // Tam, kad istraukti duomenis naudokite
            // First, FirstOrDefault, Single, SingleOrDefault, ToList
            var rezervation = _reservationRepository.Get(b => b.Id == id);

            if (rezervation == null)
            {
                return NotFound();
            }

            return Ok(rezervation); //kviecia ir knyga, suwrapint kad graziau mestu
        }


        [HttpPost("CreateReservation", Name = "CreateReservation")]
        public IActionResult Create(int bookId, int userId)
        {
            var book = _repository.Get(b => b.Id == bookId);
            var user = _userepository.Get(u => u.Id == userId);

            var checkBookQuantity = _reservationValidator.CanBookBeReserved(book);

            if(!checkBookQuantity)
            {
                return BadRequest(new { message = "Not enouth books" });
            }

            var userReaderCard = _readerCardRepository.Get(x => x.UserId == userId);

            _reservationValidator.CanUserReservBook(userReaderCard);

            var reservation = new Reservation
            {
                BookId = bookId,
                BorrowDate = DateTime.Now,
                ReaderCardId = user.UserReaderCard.Id
                
            };

            var savedReservation = _reservationRepository.Create(reservation);
            return Ok(savedReservation);
        }
        //[HttpPut("ReturnLibraryBook/{id:int}")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //public IActionResult Remove(int id) 
        //{
        //    var userBook = _userBookRepo.Get(b => b.Id == id);
        //    if (userBook == null) return NotFound("userBook == null");

        //    var libraryBook = _libraryBookRepo.Get(b => b.Id == userBook.LibraryBookId);
        //    if (libraryBook == null) return NotFound("libraryBook == null");

        //    userBook.BookReturned = DateTime.Now;
        //    _userBookRepo.Update(userBook);

        //    libraryBook.IsTaken = false;
        //    _libraryBookRepo.Update(libraryBook);

        //    _userRepo.UpdateTakenLibraryBooks(userBook.UserId, -1);

        //    return NoContent();

    
        }
}