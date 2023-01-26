using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox_Entry_Task_Nazarenko.Shapes;

namespace Mindbox_Entry_Task_NazarenkoTests.ShapesTests
{
    [TestClass()]
    public class RectangleTests
    {
        /// <summary>
        /// Tests negative inputs
        /// </summary>
        [TestMethod()]
        public void NegativeRectangleCalculateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Rectangle.Calculate(-10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Rectangle.Calculate(10, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Rectangle.Calculate(-10, -10));
        }

        /// <summary>
        /// Tests quadrangle area calculation
        /// </summary>
        [TestMethod()]
        public void RectangleCalculateTest()
        {
            Assert.AreEqual(4, Rectangle.Calculate(2, 2));
            Assert.AreEqual(2, Rectangle.Calculate(1, 2));
        }
    }
}
