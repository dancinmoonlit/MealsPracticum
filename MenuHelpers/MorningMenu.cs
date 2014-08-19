using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsPracticum
{
    public class MorningMenu : FoodMenu
    {
        public override string MealMenu(int dishType)
        {
            string[] dishTypeM = new string[3] { "eggs", "toast", "coffee" };
            try
            {
                return dishTypeM[dishType];
            }
            catch
            {
                return "error";
            }
        }

        public override bool AllowMultiple(int dishType)
        {
            if (dishType == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
