using MealsPracticum.DTO;
using System;
namespace MealsPracticum.MenuHelpers
{
    public interface IMeals
    {
        string PlaceOrder(OrderInput input);
    }
}
