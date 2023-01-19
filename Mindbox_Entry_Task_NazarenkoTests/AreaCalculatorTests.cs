using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox_Entry_Task_Nazarenko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_Entry_Task_Nazarenko.Tests
{
    [TestClass()]
    public class AreaCalculatorTests
    {
        [TestMethod()]
        public void CalculateAreaBySides_MoreThanExpectedParams_ShouldReturnZaero()
            => Assert.AreEqual(0, AreaCalculator.CalculateAreaBySides(1, 1, 1, 1, 1, 1, 1, 1));

        [TestMethod()]
        public void CalculateAreaBySides_OneSide_CalculationTest()
        {
            Assert.AreEqual(3.14, AreaCalculator.CalculateAreaBySides(1));
            Assert.AreEqual(12.57, AreaCalculator.CalculateAreaBySides(2));


            Assert.AreEqual(0, AreaCalculator.CalculateAreaBySides(-1));
        }

        [TestMethod()]
        public void CalculateAreaBySides_TwoSides_CalculationTest()
        {
            Assert.AreEqual(4, AreaCalculator.CalculateAreaBySides(2, 2));
            Assert.AreEqual(912, AreaCalculator.CalculateAreaBySides(2, 456));


            Assert.AreEqual(0, AreaCalculator.CalculateAreaBySides(-1, 1));
        }

        [TestMethod()]
        public void CalculateAreaBySides_ThreeSides_CalculationTest()
        {
            Assert.AreEqual(6, AreaCalculator.CalculateAreaBySides(3, 4, 5));
            Assert.AreEqual(28.59, AreaCalculator.CalculateAreaBySides(6, 15, 20));
            
            Assert.AreEqual(0, AreaCalculator.CalculateAreaBySides(-1, 1, 0));
        }

    }
}