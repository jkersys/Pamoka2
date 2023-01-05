using P04_EF_Applying_To_API.Models;

namespace P04_EF_Applying_To_API.Services.Adapter.IAdapters
{
    public interface ICookingService
    {
        Task CookAsync(DishOrder dishOrder);
    }
}
