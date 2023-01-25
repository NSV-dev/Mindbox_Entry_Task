using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mindbox_Entry_Task_Nazarenko.Tests
{
    [TestClass()]
    public class AreaCalculatorTests
    {
        [TestMethod()]
        public void AreaBySides_MoreThanExpectedParams_ShouldReturnZaero()
            => Assert.AreEqual(0, AreaCalculator.AreaBySides(1, 1, 1, 1, 1, 1, 1, 1));

        [TestMethod()]
        public void AreaBySides_OneSide_CalculationTest()
        {
            Assert.AreEqual(3.14, AreaCalculator.AreaBySides(1));
            Assert.AreEqual(12.57, AreaCalculator.AreaBySides(2));

            Assert.AreEqual(0, AreaCalculator.AreaBySides(-1));
        }

        [TestMethod()]
        public void AreaBySides_TwoSides_CalculationTest()
        {
            Assert.AreEqual(4, AreaCalculator.AreaBySides(2, 2));
            Assert.AreEqual(912, AreaCalculator.AreaBySides(2, 456));


            Assert.AreEqual(0, AreaCalculator.AreaBySides(-1, 1));
        }

        [TestMethod()]
        public void AreaBySides_ThreeSides_CalculationTest()
        {
            Assert.AreEqual(6, AreaCalculator.AreaBySides(3, 4, 5));
            Assert.AreEqual(28.59, AreaCalculator.AreaBySides(6, 15, 20));
            
            Assert.AreEqual(0, AreaCalculator.AreaBySides(-1, 1, 0));
        }

        [TestMethod()]
        public void CircleArea_CalculationTest()
        {
            Assert.AreEqual(3.14, AreaCalculator.CircleArea(1));
            Assert.AreEqual(12.57, AreaCalculator.CircleArea(2));

            Assert.AreEqual(0, AreaCalculator.CircleArea(-1));
        }

        [TestMethod()]
        public void QuadrangleArea_CalculationTest()
        {
            Assert.AreEqual(4, AreaCalculator.QuadrangleArea(2, 2));
            Assert.AreEqual(912, AreaCalculator.QuadrangleArea(2, 456));


            Assert.AreEqual(0, AreaCalculator.QuadrangleArea(-1, 1));
        }

        [TestMethod()]
        public void TriangleArea_CalculationTest()
        {
            Assert.AreEqual(6, AreaCalculator.TriangleArea(3, 4, 5));
            Assert.AreEqual(28.59, AreaCalculator.TriangleArea(6, 15, 20));

            Assert.AreEqual(0, AreaCalculator.TriangleArea(-1, 1, 0));
        }

        [TestMethod()]
        public void IsRiaghtTriangle_CalculationTest()
        {
            Assert.AreEqual(true, AreaCalculator.IsRiaghtTriangle(3, 4, 5));
            Assert.AreEqual(false, AreaCalculator.IsRiaghtTriangle(6, 15, 20));

            Assert.AreEqual(false, AreaCalculator.IsRiaghtTriangle(-1, 1, 0));
        }
    }
}