﻿namespace P04_EF_Applying_To_API.Models.Dto
{
    public class GetRecipeItemDto
    {
        public GetRecipeItemDto(RecipeItem recipeItem)
        {
            Name = recipeItem.Name;
            Calories = recipeItem.Calories;
        }

        public string Name { get; set; }
        public double Calories { get; set; }
    }
}
