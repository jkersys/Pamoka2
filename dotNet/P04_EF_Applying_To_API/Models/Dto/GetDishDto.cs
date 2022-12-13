namespace P04_EF_Applying_To_API.Models.Dto
{
    public class GetDishDto
    {
        public GetDishDto(Dish dish)
        {
            Name = dish.Name;
            Type = dish.Type;
            SpiceLevel = dish.SpiceLevel;
            Country = dish.Country;
            RecipeItems = dish.RecipeItems 
                .Select(ri => new GetRecipeItemDto(ri)) //permapinam recipeItem i GetRecipeItemDto (gaunam nauja objekta, pasiimam tik tuos parametrus, kuriu reikia frontendo vaizdavimui)
                .ToList();
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string SpiceLevel { get; set; }
        public string Country { get; set; }
        public List<GetRecipeItemDto> RecipeItems { get; set; } = new List<GetRecipeItemDto>();
    }
}
