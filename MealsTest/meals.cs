using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MealsTest
{
    [TestClass]
    public class meals
    {
        List<Order> listOrder = new List<Order>();
        [TestMethod]
        public void MealsTestMethod()
        {
            string[] mealTime = new string[2] { "morning", "evening" };
            string[] dishType = new string[4] { "entree", "side", "drink", "dessser" };
            string[] dishTypeM = new string[3] { "eggs", "toast", "coffee"  };
            string[] dishTypeN = new string[4] { "steak", "potato", "wine", "cake" };

        }

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
            for (int i = 0; i < orderIn.Length; i++)
            {
                Console.WriteLine(orderIn[i]);
            }

        }
    }

    class Order
    {
        public virtual string order { get; set; } 
    }
}
