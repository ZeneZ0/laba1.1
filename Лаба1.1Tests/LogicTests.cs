using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zad12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad12.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void ConvertKopecksToRubles_321_ReturnsCorrectString()
        {
            
            int kopecks = 321;
            string expected = "3 рубля 21 копейка";

            
            string result = Logic.ConvertKopecksToRubles(kopecks);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertKopecksToRubles_1505_ReturnsCorrectString()
        {
            
            int kopecks = 1505;
            string expected = "15 рублей 5 копеек";

            
            string result = Logic.ConvertKopecksToRubles(kopecks);

           
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertKopecksToRubles_100_ReturnsCorrectString()
        {
            
            int kopecks = 100;
            string expected = "1 рубль";

            
            string result = Logic.ConvertKopecksToRubles(kopecks);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertKopecksToRubles_0_ReturnsCorrectString()
        {
            
            int kopecks = 0;
            string expected = "0 рублей 0 копеек";

            
            string result = Logic.ConvertKopecksToRubles(kopecks);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertKopecksToRubles_50_ReturnsCorrectString()
        {
            
            int kopecks = 50;
            string expected = "50 копеек";

            
            string result = Logic.ConvertKopecksToRubles(kopecks);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertKopecksToRubles_5000_ReturnsCorrectString()
        {
           
            int kopecks = 5000;
            string expected = "50 рублей";

            
            string result = Logic.ConvertKopecksToRubles(kopecks);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertKopecksToRubles_101_ReturnsCorrectString()
        {
           
            int kopecks = 101;
            string expected = "1 рубль 1 копейка";

         
            string result = Logic.ConvertKopecksToRubles(kopecks);

           
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ConvertKopecksToRubles_115_ReturnsCorrectString()
        {
            
            int kopecks = 115;
            string expected = "1 рубль 15 копеек";

            
            string result = Logic.ConvertKopecksToRubles(kopecks);

            
            Assert.AreEqual(expected, result);
        }
    }

}