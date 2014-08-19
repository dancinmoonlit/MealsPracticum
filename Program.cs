using MealsPracticum.DTO;
using MealsPracticum.MenuHelpers;
using System;

namespace MealsPracticum
{
    class Program
    {
        static void Main(string[] args)
        {
            IMeals orders = new Meals();

            OrderInput input = new OrderInput();

            if (args == null || args.Length <= 0)
            {
                Console.WriteLine("Please provide inputs.");
                return;
            }

            input.Order = args[0];
            string output = orders.PlaceOrder(input);
            Console.WriteLine(output);
            Console.Read();
        }
    }
}
