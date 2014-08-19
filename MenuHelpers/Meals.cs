using MealsPracticum;
using MealsPracticum.DTO;
using MealsPracticum.MenuHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MealsPracticum
{
    public class Meals : MealsPracticum.MenuHelpers.IMeals
    {
        string[] dishTypeM = new string[3] { "eggs", "toast", "coffee" };
        string[] dishTypeN = new string[4] { "steak", "potato", "wine", "cake" };

        public string PlaceOrder(OrderInput orderInput)
        {
            string[] orderIn = orderInput.Order.Split(',');

            List<string> listOrderRequest = new List<string>(orderIn);
            //listOrderRequest.Sort();

            List<string> mealReady = new List<string>();
            FoodMenu foodMenu = MenuFactory.GetMenu(orderIn[0]);
                        
            for (int i = 1; i < listOrderRequest.Count; i++)
            {
                int orderMeals = Convert.ToInt32(listOrderRequest[i]) - 1;
                if ((i + 1 < listOrderRequest.Count) && listOrderRequest[i] == listOrderRequest[i + 1])
                {
                    if (foodMenu.AllowMultiple(orderMeals))
                        mealReady.Add(foodMenu.MealMenu(orderMeals));
                    else
                    {
                        mealReady.Add(foodMenu.MealMenu(orderMeals));
                        mealReady.Add("error");
                        break;
                    }
                }
                else
                {
                    mealReady.Add(foodMenu.MealMenu(orderMeals));
                }
            }

            //mealReady = mealReady.Distinct().ToList(); 
            //Format the Desired output. 
            // Checks for repeated
            /*
             * 
             * Rules:

                1. You must enter time of day as “morning” or “night” 

                2. You must enter a comma delimited list of dish types with at least one selection

                3. The output must print food in the following order: entrée, side, drink, dessert

                4. There is no dessert for morning meals

                5. Input is not case sensitive

                6. If invalid selection is encountered, display valid selections up to the error, then print error

                7. In the morning, you can order multiple cups of coffee

                8. At night, you can have multiple orders of potatoes

                9. Except for the above rules, you can only order 1 of each dish type
             */

            var groupedList = mealReady.GroupBy(x => x).Select(y => new { y.Key, nbrof = y.Count() }).ToList();
            List<string> mealItems = new List<string>();

            foreach (var group in groupedList)
            {
                if (group.nbrof > 1)
                {
                    mealItems.Add(group.Key + "(x" + group.nbrof + ")");
                }
                else
                {
                    mealItems.Add(group.Key);
                }
            }

            string mealsReady = string.Join(", ", mealItems.ToArray());
            Console.WriteLine(mealsReady);
            //GetOrder();

            return mealsReady;
        }
    }    
}
