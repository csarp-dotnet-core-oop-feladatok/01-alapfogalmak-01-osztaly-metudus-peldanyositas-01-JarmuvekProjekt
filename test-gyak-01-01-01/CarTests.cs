using Microsoft.VisualStudio.TestTools.UnitTesting;
using gyak_01_01_01_poliomorf_metodusok;
using System;
using System.Collections.Generic;
using System.Text;

using System.IO;

namespace gyak_01_01_01_poliomorf_metodusok.Tests
{
    [TestClass()]
    public class BicycleTests
    {
        [TestMethod()]
        public void GoToWorkTest()
        {
            Car car = new Car();
            string expected = "Autó megy munkahelyre.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            car.GoToWork();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A GoToWork függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void ComingHomeTest()
        {
            Car car = new Car();
            string expected = "Autó megy haza.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            car.ComingHome();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A ComingHome függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}