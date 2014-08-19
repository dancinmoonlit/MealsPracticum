using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MealsPracticum;

namespace MealsTest
{
    [TestClass]
    public class EveningMenuTest
    {
        FoodMenu _menu;
        [TestInitialize]
        public void Init()
        {
            _menu = new EveningMenu();
        }        

        [TestMethod]
        public void Test_EveningMenu_Dish_1()
        {        
            string dish = _menu.MealMenu(0);
            Assert.AreEqual(dish, "steak");
        }

        [TestMethod]
        public void Test_EveningMenu_Dish_2()
        {
            string dish = _menu.MealMenu(1);
            Assert.AreEqual(dish, "potato");
        }

        [TestMethod]
        public void Test_EveningMenu_Dish_3()
        {
            string dish = _menu.MealMenu(2);
            Assert.AreEqual(dish, "wine");
        }

        [TestMethod]
        public void Test_EveningMenu_Dish_4()
        {
            string dish = _menu.MealMenu(3);
            Assert.AreEqual(dish, "cake");
        }

        [TestMethod]        
        public void Test_EveningMenu_Dish_Invalid()
        {
            string dish = _menu.MealMenu(4);
            Assert.AreEqual(dish, "error");
        }

        [TestMethod]
        public void Test_AlloWMultiple_Positive()
        {
          Assert.IsTrue(_menu.AllowMultiple(1));
        }

        [TestMethod]
        public void Test_AlloWMultiple_Negative_WithInRange()
        {
          Assert.IsFalse(_menu.AllowMultiple(2));
        }

        [TestMethod]
        public void Test_AlloWMultiple_Negative_OutOFRange()
        {
          Assert.IsFalse(_menu.AllowMultiple(10));
        }

    }
}
