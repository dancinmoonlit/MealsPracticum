using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealsPracticum
{
    public class FoodMenu
    {
        public virtual string MealMenu(int dishType)
        {
            string[] dishTypes = new string[4] { "entree", "side", "drink", "dessser" };
            return dishTypes[dishType];
        }

        public virtual bool AllowMultiple(int dishType) { return true; }
    }
}
