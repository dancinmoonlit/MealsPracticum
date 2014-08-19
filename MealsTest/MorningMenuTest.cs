using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MealsPracticum;

namespace MealsTest
{
    [TestClass]
    public class MorningMenuTest
    {
        FoodMenu _menu;
        [TestInitialize]
        public void Init()
        {
            _menu = new MorningMenu();
        }

        [TestMethod]
        public void Test_MorningMenu_Dish_1()
        {
            string dish = _menu.MealMenu(0);
            Assert.AreEqual(dish, "eggs");
        }

        [TestMethod]
        public void Test_MorningMenu_Dish_2()
        {
            string dish = _menu.MealMenu(1);
            Assert.AreEqual(dish, "toast");
        }

        [TestMethod]
        public void Test_MorningMenu_Dish_3()
        {
            string dish = _menu.MealMenu(2);
            Assert.AreEqual(dish, "coffee");
        }

        [TestMethod]
        public void Test_MorningMenu_Dish_Invalid()
        {
            string dish = _menu.MealMenu(3);
            Assert.AreEqual(dish, "error");
        }

        [TestMethod]
        public void Test_AlloWMultiple_Positive()
        {
            Assert.IsTrue(_menu.AllowMultiple(2));
        }

        [TestMethod]
        public void Test_AlloWMultiple_Negative_WithInRange()
        {
            Assert.IsFalse(_menu.AllowMultiple(1));
        }

        [TestMethod]
        public void Test_AlloWMultiple_Negative_OutOFRange()
        {
            Assert.IsFalse(_menu.AllowMultiple(10));
        }
    }
}
