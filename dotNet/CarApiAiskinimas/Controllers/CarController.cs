using CarApiAiskinimas.Models;
using CarApiAiskinimas.Models.Dto;
using CarApiAiskinimas.Repositories;
using CarApiAiskinimas.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mime;

namespace CarApiAiskinimas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
     
        private readonly ILogger<CarController> _logger;
        private readonly ICarRepository _repository;
        private readonly ICarAdapter _adapter;

        public CarController(ILogger<CarController> logger, ICarRepository repository, ICarAdapter adapter)
        {
            _logger = logger;
            _repository = repository;
            _adapter = adapter;
        }

        //ISTRINAM GET, NES FILTER MEODAS TAIP PAT GRAZINA VISUS AUTO, BEI DAR LEIDZIA FILTRUOTI.
        ///// <summary>
        ///// Gaunamas duomenubazeje esanciu automobiliu sarasas
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        //[Produces(MediaTypeNames.Application.Json)]
        //public IActionResult Get()
        //{
        //    var entities = _repository.All();
        //    var model = entities.Select(x => _adapter.Bind(x));
        //    return Ok(model);
        //}



        /// <summary>
        /// Grazina auto sarasa, taip pat galima gauti sfiltruotas duomenubazeje esanciu automobiliu sarasas
        /// </summary>
        /// <returns></returns>
        [HttpGet("filter")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get([FromQuery]FilterCarRequest req)
        {
            _logger.LogInformation("Getting car list with parameters {req}", JsonConvert.SerializeObject(req));
            IEnumerable<Car> entities = _repository.All().ToList();

            if (req.Mark != null)
                entities = entities.Where(x => x.Mark == req.Mark);

            if (req.Model != null)
                entities = entities.Where(x => x.Model == req.Model);

            if (req.GearBox != null)
                entities = entities.Where(x => x.GearBox == (ECarGearBox)Enum.Parse(typeof(ECarGearBox), req.GearBox));

            if (req.Fuel != null)
                entities = entities.Where(x => x.Fuel == (ECarFuel)Enum.Parse(typeof(ECarFuel), req.Fuel));

            var model = entities?.Select(x => _adapter.Bind(x));

            return Ok(model);
        }
        /// <summary>
        /// Gaunamas vienas automobilis is duomenu bazes
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetCarResult>))]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult Get(int id)
        {
            if (!_repository.Exist(id))
            {
                _logger.LogInformation("Car with id {id} was not found",id);
                return NotFound();
            }
            var entity = _repository.Get(id);
            var model = _adapter.Bind(entity);
            return Ok(model);
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
        public IActionResult Post(PostCarRequest req)
        {
            //Custom validacija
            if(Enum.TryParse(typeof(ECarGearBox), req.GearBox, out _))
            {
                var validValues = Enum.GetNames(typeof(ECarGearBox));
                ModelState.AddModelError(nameof(req.GearBox), $"Not valid value. Valid values are: {string.Join(", ", validValues)}");
            }
            if (Enum.TryParse(typeof(ECarFuel), req.Fuel, out _))
            {
                var validValues = Enum.GetNames(typeof(ECarFuel));
                ModelState.AddModelError(nameof(req.Fuel), $"Not valid value. Valid values are: {string.Join(", ", validValues)}");
            }
            //
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var entity = _adapter.Bind(req);
            var id = _repository.Create(entity);
            return Created("PostCar", new {Id = id});
        }

        /// <summary>
        /// Modifikuojamas automobilis duomenu bazeje
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Put(PutCarRequest req)
        {
            if (Enum.TryParse(typeof(ECarGearBox), req.GearBox, out _))
            {
                var validValues = Enum.GetNames(typeof(ECarGearBox));
                ModelState.AddModelError(nameof(req.GearBox), $"Not valid value. Valid values are: {string.Join(", ", validValues)}");
            }
            if (Enum.TryParse(typeof(ECarFuel), req.Fuel, out _))
            {
                var validValues = Enum.GetNames(typeof(ECarFuel));
                ModelState.AddModelError(nameof(req.Fuel), $"Not valid value. Valid values are: {string.Join(", ", validValues)}");
            }
            //
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }
            if(!_repository.Exist(req.Id))
            {
                _logger.LogInformation("Car with id {id} was not found", req.Id);
                return NotFound();
            }

            var entity = _adapter.Bind(req);
            _repository.Update(entity);
            return NoContent();
        }
        /// <summary>
        /// Istrinamas automobilis is duomenu bazes
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Delete(int id)
        {
            if (!_repository.Exist(id))
            {
                _logger.LogInformation("Car with id {id} was not found", id);
                return NotFound();
            }
            var entity = _repository.Get(id);
            _repository.Remove(entity);
            return NoContent();
        }
    }
}