using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P04_EF_Applying_To_API.Data;
using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;
using P04_EF_Applying_To_API.Repository.IRepository;
using P04_EF_Applying_To_API.Services.Adapter.IAdapters;

namespace P04_EF_Applying_To_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly IDishRepository _dishRepo;
        private readonly IDishAdapter _dishAdapter;
        public DishesController(IDishRepository dishRepo, IDishAdapter dishAdapter)
        {
            _dishRepo = dishRepo;
            _dishAdapter = dishAdapter;
        }

        [HttpGet("dishes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDto>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDishes()
        {
            var dishes = await _dishRepo.GetAllAsync();
            return Ok(dishes
            .Select(d => new GetDishDto(d))
            .ToList());
        }
        [HttpGet("dishes/{id:int}", Name = "GetDish")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetDishDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDishDto>> GetDishById(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var dish = await _dishRepo.GetAsync(d => d.DishId == id);

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
        public async Task<ActionResult<CreateDishDto>> CreateDish(CreateDishDto dishDto)
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

           await _dishRepo.CreateAsync(model);

            return CreatedAtRoute("GetDish", new { id = model.DishId }, dishDto);
        }
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("dishes/delete{id:int}")]
        [Authorize(Roles = "super-admin")]
        public async Task<ActionResult> DeleteDish(int id)
        {
            if(id == 0)
            {
                return BadRequest(); 
            }
            var dish = await _dishRepo.GetAsync(d => d.DishId == id);
        

            if(dish == null)
            {
                return NotFound();
            }
           await _dishRepo.RemoveAsync(dish);
          

            return NoContent();
        }
        [HttpPut("dishes/update/{id:int}")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateDish(int id, UpdateDishDto updateDishDTO)
        {
            if (id == 0 || updateDishDTO == null)
            {
                return BadRequest();
            }

            var foundDish = await _dishRepo.GetAsync(d => d.DishId == id);

            if (foundDish == null)
            {
                return NotFound();
            }

            foundDish.Name = updateDishDTO.Name;
            foundDish.ImagePath = updateDishDTO.ImagePath;
            foundDish.Type = updateDishDTO.Type;
            foundDish.SpiceLevel = updateDishDTO.SpiceLevel;
            foundDish.Country = updateDishDTO.Country;

            await _dishRepo.UpdateAsync(foundDish);

            return NoContent();
        }

        /*
          https://jsonpatch.com/
            [
              {
                "path": "/Name",
                "op": "replace",
                "value": "Patched with DTO value"
              }
            ]
            [
              {
                "path": "/RecipeItems",
                "op": "add",
                "value": [{
            "Name":"TestRecipeItem",
            "Calories":"50"
            }]
              }
            ]
         */
        [HttpPatch("patch/{id:int}", Name = "UpdatePartialDish")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdatePartialDish(int id, JsonPatchDocument<Dish> request)
        {
            if (id == 0 || request == null)
            {
                return BadRequest();
            }

            var dishExists = await _dishRepo.ExistAsync(d => d.DishId == id);

            if (!dishExists)
            {
                return NotFound();
            }

            var foundDish = await _dishRepo.GetAsync(d => d.DishId == id);

            request.ApplyTo(foundDish, ModelState);

            await _dishRepo.UpdateAsync(foundDish);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }

        [HttpPatch("patch/{id:int}/dto", Name = "UpdatePartialDishDto")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdatePartialDishByDto(int id, JsonPatchDocument<UpdateDishDto> request)
        {
            if (id == 0 || request == null)
            {
                return BadRequest();
            }

            var dishExists = await _dishRepo.ExistAsync(d => d.DishId == id);

            if (!dishExists)
            {
                return NotFound();
            }

            var foundDish = await _dishRepo.GetAsync(d => d.DishId == id, tracked: false);

            var updateDishDto = _dishAdapter.Bind(foundDish);

            request.ApplyTo(updateDishDto, ModelState);

            var dish = _dishAdapter.Bind(updateDishDto, foundDish.DishId);

            await _dishRepo.UpdateAsync(dish);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}