using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsPracticum
{
    public class TimeofDay
    {
        string[] mealTime = new string[2] { "morning", "evening" };

        public string TimeOfDay(int mlTime)
        {
            return this.mealTime[mlTime];
        }
    }
}
