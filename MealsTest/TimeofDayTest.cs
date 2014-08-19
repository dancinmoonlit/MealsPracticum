using MealsPracticum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MealsTest
{
    [TestClass]
    public class TimeofDayTest
    {
        TimeofDay timeOfDay;

        [TestInitialize]
        public void Init()
        {
            timeOfDay = new TimeofDay();
        }

        [TestMethod]
        public void Test_TimeOfDay_Morning()
        {
            string time = timeOfDay.TimeOfDay(0);
            Assert.AreEqual(time, "morning");
        }

        [TestMethod]
        public void Test_TimeOfDay_Evening()
        {
            string time = timeOfDay.TimeOfDay(1);
            Assert.AreEqual(time, "evening");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Test_TimeOfDay_Invalid()
        {
            string time = timeOfDay.TimeOfDay(2);
        }
    }
}
