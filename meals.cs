using System;
using System.Collections.Generic;
using System.Linq;

namespace MealsTest
{
    public class meals
    {
        List<Order> listOrder = new List<Order>();
        
        string[] dishTypeM = new string[3] { "eggs", "toast", "coffee" };
        string[] dishTypeN = new string[4] { "steak", "potato", "wine", "cake" };

        public string getOrder() {

            Console.WriteLine("\n\nEnter your order\t");
            string orderInput = Console.ReadLine();
            Order orderDetails = new Order();
            orderDetails.order = orderInput;
            listOrder.Add(orderDetails);

            processOrder(orderDetails);
            return orderInput;
       }

        public void processOrder(Order orderI)
        {
            string[] orderIn = orderI.order.Split(',');
            List<string> listOrderRequest = new List<string>(orderIn);
            listOrderRequest.Sort();
            List<string> mealReady = new List<string>();

            for (int i = 0; i < listOrderRequest.Count - 1; i++)
            {
                int orderMeals = Convert.ToInt32(listOrderRequest[i]);
                TimeofDay tOfD = new TimeofDay();
                if (orderIn[0] == tOfD.TimeOfDay(0))
                {
                    Morning foodMenu = new Morning();
                    mealReady.Add(foodMenu.MealMenu(orderMeals - 1));
                }
                else
                {
                    Evening foodMenu = new Evening();
                    mealReady.Add(foodMenu.MealMenu(orderMeals - 1));
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

            var groupedList = mealReady.GroupBy(x => x).Select (y =>new{ y.Key,nbrof=y.Count ()} ).ToList();
            List<string> mealItems = new List<string>();

            foreach (var group in groupedList)
            {
                if (group.nbrof > 1)
                {
                    mealItems.Add( group.Key + "(x" + group.nbrof + ")");
                }
                else
                {
                    mealItems.Add(group.Key);
                }

            }

            string mealsReady = string.Join(",", mealItems.ToArray());
            Console.WriteLine(mealsReady);
            getOrder();

            Console.ReadLine();

        }
    }

    public class Order
    {
        public virtual string order { get; set; }
    }

    public class FoodMenu
    {
        public string MealMenu(int dishType) {
            string[] dishTypes = new string[4] { "entree", "side", "drink", "dessser" };
            return dishTypes[dishType];
        }
    }

    public class Morning : FoodMenu
    {
        public string MealMenu(int dishType)
        {
            string[] dishTypeM = new string[3] { "eggs", "toast", "coffee" };
            try
            {
                return dishTypeM[dishType];
            }
            catch
            {
                return "Error";
            }
        }
    }

    public class Evening : FoodMenu
    {
        public string MealMenu(int dishType)
        {
            string[] dishTypeN = new string[4] { "steak", "potato", "wine", "cake" };
            try
            {
                return dishTypeN[dishType];
            }
            catch
            {
                return "Error";
            }
        }
    }

    public class TimeofDay {
        string[] mealTime = new string[2] { "morning", "evening" };

        public string TimeOfDay(int mlTime)
        {
            return this.mealTime[mlTime];
        }
    }
}
