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
        public void GoToWorkTestBicycle()
        {
            Bicycle bicycle = new Bicycle();
            string expected = "Kerékpár megy munkahelyre.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            bicycle.GoToWork();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Bicycle->GoToWork függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void ComingHomeTest()
        {
            Bicycle bicycle = new Bicycle();
            string expected = "Kerékpár megy haza.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            bicycle.ComingHome();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Bicycle->ComingHome függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}