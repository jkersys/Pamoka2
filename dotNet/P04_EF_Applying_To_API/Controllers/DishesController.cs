using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P04_EF_Applying_To_API.Data;
using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;
using P04_EF_Applying_To_API.Repository.IRepository;

namespace P04_EF_Applying_To_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishRepository _dishRepo;
        public DishesController(IDishRepository dishRepo)
        {
            _dishRepo = dishRepo;
        }

        [HttpGet("dishes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetDishDto>> GetDishes()
        {
            return Ok(_dishRepo.GetAll()
            .Select(d => new GetDishDto(d))
            .ToList());
        }
        [HttpGet("dishes/{id:int}", Name = "GetDish")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetDishDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<GetDishDto> GetDishById(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var dish = _dishRepo.Get(d => d.DishId == id);

            if(dish == null)
            {
                return NotFound();
            }
            return Ok(new GetDishDto(dish));
        }

        [HttpPost("dishes")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(CreateDishDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateDishDto> CreateDish(CreateDishDto dishDto)
        {
            if (dishDto == null)
            {
                return BadRequest();
            }
            //sumapinam kad tiktu duombazei is front endo paduodamas naujas Dish
            Dish model = new Dish()
            {
                Country = dishDto.Country,
                SpiceLevel = dishDto.SpiceLevel,
                Type = dishDto.Type,
                Name = dishDto.Name,
                CreateDateTime = dishDto.CreateDateTime,
                ImagePath = dishDto.ImagePath
            };

            _dishRepo.Create(model);

            return CreatedAtRoute("GetDish", new { id = model.DishId }, dishDto);
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("dishes/delete{id:int}")]
        [Authorize(Roles = "super-admin")]
        public ActionResult DeleteDish(int id)
        {
            if(id == 0)
            {
                return BadRequest(); 
            }
            var dish = _dishRepo.Get(d => d.DishId == id);
        

            if(dish == null)
            {
                return NotFound();
            }
            _dishRepo.Remove(dish);
          

            return NoContent();
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("dishes/update{id:int}")]
        [Authorize(Roles = "admin")]
        public ActionResult UpdateDish(int id, UpdateDishDto updateDishDto)
        {
            if(id == 0 || updateDishDto == null || updateDishDto.DishId != id)
            {
                return BadRequest();
            }
            var foundDish = _dishRepo.Get(d => d.DishId == id);

            if (foundDish == null)
            {
                return NotFound();
            }

            foundDish.Name = updateDishDto.Name;
            foundDish.ImagePath = updateDishDto.ImagePath;
            foundDish.Type = updateDishDto.Type;
            foundDish.SpiceLevel = updateDishDto.SpiceLevel;
            foundDish.Country = updateDishDto.Country;

            _dishRepo.Update(foundDish);

            return NoContent();


        }

    }
}
