using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mindbox_Entry_Task_Nazarenko.Tests
{
    [TestClass()]
    public class AreaCalculatorTests
    {
        /// <summary>
        /// Tests more than expected inputs
        /// </summary>
        [TestMethod()]
        public void MoreThanExpectedParamsAreaBySidesTest()
            => Assert.ThrowsException<Exception>(() => AreaCalculator.AreaBySides(1, 1, 1, 1, 1, 1, 1, 1));

        /// <summary>
        /// Tests negative inputs
        /// </summary>
        [TestMethod()]
        public void NegativeAreaBySidesTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(-1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(-1, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(1, -1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(-1, -1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(-1, 1, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(1, -1, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(1, 1, -1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => AreaCalculator.AreaBySides(-1, -1, -1));
        }

        /// <summary>
        /// Tests area by sides calculations
        /// </summary>
        [TestMethod()]
        public void NormalAreaBySidesTest()
        {
            Assert.AreEqual(3.14, AreaCalculator.AreaBySides(1));
            Assert.AreEqual(4, AreaCalculator.AreaBySides(2, 2));
            Assert.AreEqual(6, AreaCalculator.AreaBySides(3, 4, 5));
        }
    }
}