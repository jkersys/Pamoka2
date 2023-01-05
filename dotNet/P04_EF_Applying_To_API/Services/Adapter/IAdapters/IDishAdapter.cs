using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;

namespace P04_EF_Applying_To_API.Services.Adapter.IAdapters
{
    public interface IDishAdapter
    {
        UpdateDishDto Bind(Dish dish);
        Dish Bind(UpdateDishDto updateDishDTO, int id);
    }
}
