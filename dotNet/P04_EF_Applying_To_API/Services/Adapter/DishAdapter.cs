using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;
using P04_EF_Applying_To_API.Services.Adapter.IAdapters;

namespace P04_EF_Applying_To_API.Services.Adapter
{
    public class DishAdapter : IDishAdapter
    {
        public UpdateDishDto Bind(Dish dish)
        {
            return new UpdateDishDto
            {
                Country = dish.Country,
                ImagePath = dish.ImagePath,
                Name = dish.Name,
                SpiceLevel = dish.SpiceLevel,
                Type = dish.Type
            };
        }

        public Dish Bind(UpdateDishDto updateDishDTO, int id)
        {
            return new Dish
            {
                Country = updateDishDTO.Country,
                ImagePath = updateDishDTO.ImagePath,
                Name = updateDishDTO.Name,
                SpiceLevel = updateDishDTO.SpiceLevel,
                Type = updateDishDTO.Type,
                DishId = id
            };
        }
    }
}