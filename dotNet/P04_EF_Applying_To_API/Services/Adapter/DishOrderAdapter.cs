﻿using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;
using P04_EF_Applying_To_API.Services.Adapter.IAdapters;

namespace P04_EF_Applying_To_API.Services.Adapter
{
    public class DishOrderAdapter : IDishOrderAdapter
    {
        public GetOrderResponse Bind(DishOrder dishOrder)
        {
            return new GetOrderResponse
            {
                User = dishOrder.LocalUser,
                Dish = dishOrder.Dish
            };
        }

        public DishOrder Bind(CreateOrderRequest request)
        {
            return new DishOrder
            {
                DishId = request.DishId,
                LocalUserId = request.UserId
            };
        }

        public CreateOrderResponse Bind(Dish dish)
        {
            return new CreateOrderResponse
            {
                DishName = dish.Name,
                CoockingFinnishDateTime = DateTime.Now.AddMinutes(30),
                State = "Preparing"
            };
        }
    }
}
