using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using P04_EF_Applying_To_API.Controllers;
using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;
using P04_EF_Applying_To_API.Repository.IRepository;
using P04_EF_Applying_To_API.Services.Adapter.IAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P04_EF_Applying_To_API.Controllers.Tests
{
    [TestClass()]
    public class DishesControllerTests
    {
        [TestMethod()]
        public async Task GetDishes_ShouldReturnAllDishes()
        {
            //Arrange
            var dish_repository_Mock = new Mock<IDishRepository>();
            var dish_adapter_Mock = new Mock<IDishAdapter>();
            var fakeObj = new List<Dish>
            {
                new Dish {DishId = 1, Name = "First dish", Type = "Test type", SpiceLevel = "Very spicy", Country = "Test country", RecipeItems = new List<RecipeItem>()},
                new Dish {DishId = 2, Name = "Second dish", Type = "Test type", SpiceLevel = "Not spicy", Country = "Test country", RecipeItems = new List<RecipeItem>()},
            };
            var expected = new List<GetDishDto>
            {
                new GetDishDto(fakeObj[0]),
                new GetDishDto(fakeObj[1])
            };
            dish_repository_Mock.Setup(d => d.GetAllAsync(It.IsAny<Expression<Func<Dish, bool>>>())).ReturnsAsync(fakeObj);

            var dishControler = new DishesController(dish_repository_Mock.Object, dish_adapter_Mock.Object);

            //Act

            var sut = await dishControler.GetDishes() as OkObjectResult;

            //Assert
            Assert.AreEqual(expected[0].Name, (sut.Value as List<GetDishDto>)[0].Name);
            Assert.AreEqual(expected[1].Name, (sut.Value as List<GetDishDto>)[1].Name);
        }
    }
}