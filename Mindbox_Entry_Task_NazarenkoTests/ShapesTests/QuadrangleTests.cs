using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox_Entry_Task_Nazarenko.Shapes;

namespace Mindbox_Entry_Task_NazarenkoTests.ShapesTests
{
    [TestClass()]
    public class QuadrangleTests
    {
        /// <summary>
        /// Tests negative inputs
        /// </summary>
        [TestMethod()]
        public void NegativeQuadrangleCalculateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Quadrangle.Calculate(-10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Quadrangle.Calculate(10, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Quadrangle.Calculate(-10, -10));
        }

        /// <summary>
        /// Tests quadrangle area calculation
        /// </summary>
        [TestMethod()]
        public void QuadrangleCalculateTest()
        {
            Assert.AreEqual(4, Quadrangle.Calculate(2, 2));
            Assert.AreEqual(2, Quadrangle.Calculate(1, 2));
        }
    }
}
