using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsPracticum.MenuHelpers
{
    public class MenuFactory
    {
        public static FoodMenu GetMenu(string timeOfDay)
        {
            TimeofDay tOfD = new TimeofDay();
            if (timeOfDay == tOfD.TimeOfDay(0))
            {
               return new MorningMenu();
            }
            else if (timeOfDay == tOfD.TimeOfDay(1))
            {
                return new EveningMenu();
            }
            return null;
        }
    }
}
