using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsPracticum
{
    public class EveningMenu : FoodMenu
    {
        public override string MealMenu(int dishType)
        {
            string[] dishTypeN = new string[4] { "steak", "potato", "wine", "cake" };
            try
            {
                return dishTypeN[dishType];
            }
            catch
            {
                return "error";
            }
        }

        public override bool AllowMultiple(int dishType)
        {
            if (dishType == 1)
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
