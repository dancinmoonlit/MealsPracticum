using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MealsPracticum;
using MealsPracticum.MenuHelpers;
using MealsPracticum.DTO;

namespace MealsTest
{
    [TestClass]
    public class MealsTest
    {
        IMeals _meals;
        OrderInput input;

        [TestInitialize]
        public void Init()
        {
            _meals = new Meals();
            input = new OrderInput();
        }

        [TestMethod]
        public void Test_PlaceOrder_1()
        {
            input.Order = "morning, 1, 2, 3";
            string desiredOutput = "eggs, toast, coffee";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod]
        public void Test_PlaceOrder_2()
        {
            input.Order = "morning, 2, 1, 3";
            string desiredOutput = "toast, eggs, coffee";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod]
        public void Test_PlaceOrder_3()
        {
            input.Order = "morning, 1, 2, 3, 4";
            string desiredOutput = "eggs, toast, coffee, error";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod]
        public void Test_PlaceOrder_4()
        {
            input.Order = "morning, 1, 2, 3, 3, 3";
            string desiredOutput = "eggs, toast, coffee(x3)";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod]
        public void Test_PlaceOrder_5()
        {
            input.Order = "evening, 1, 2, 3, 4";
            string desiredOutput = "steak, potato, wine, cake";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod]
        public void Test_PlaceOrder_6()
        {
            input.Order = "evening, 1, 2, 2, 4";
            string desiredOutput = "steak, potato(x2), cake";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }

        [TestMethod]
        public void Test_PlaceOrder_7()
        {
            input.Order = "evening, 1, 2, 3, 5";
            string desiredOutput = "steak, potato, wine, error";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }


        [TestMethod]
        public void Test_PlaceOrder_8()
        {
            input.Order = "evening, 1, 1, 2, 3, 5";
            string desiredOutput = "steak, error";
            string output = _meals.PlaceOrder(input);
            Assert.AreEqual(desiredOutput, output);
        }
    }
}

