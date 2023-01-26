using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox_Entry_Task_Nazarenko;
using Mindbox_Entry_Task_Nazarenko.Shapes;

namespace Mindbox_Entry_Task_NazarenkoTests.ShapesTests
{
    [TestClass()]
    public class TriangleTests
    {
        #region Caculate Tests
        /// <summary>
        /// Tests negative inputs
        /// </summary>
        [TestMethod()]
        public void NegativeCalculateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.Calculate(-10, 10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.Calculate(10, -10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.Calculate(10, 10, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.Calculate(-10, -10, -10));
        }

        /// <summary>
        /// Tests if given inputs are not a triangle
        /// </summary>
        [TestMethod()]
        public void SidesAreNotTrtiangleCalculateTest()
        {
            Assert.ThrowsException<ArgumentException>(() => Triangle.Calculate(10, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => Triangle.Calculate(1, 10, 1));
            Assert.ThrowsException<ArgumentException>(() => Triangle.Calculate(1, 1, 10));
        }

        /// <summary>
        /// Tests triangle area calculation
        /// </summary>
        [TestMethod()]
        public void NormalCalculateTest() 
            => Assert.AreEqual(6, AreaCalculator.TriangleArea(3, 4, 5));
        #endregion

        #region IsRight Tests
        /// <summary>
        /// Tests negative inputs
        /// </summary>
        [TestMethod()]
        public void NegativeIsRightTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.IsRight(-10, 10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.IsRight(10, -10, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.IsRight(10, 10, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Triangle.IsRight(-10, -10, -10));
        }

        /// <summary>
        /// Tests if given inputs are not a triangle
        /// </summary>
        [TestMethod()]
        public void SidesAreNotTrtiangleIsRightTest()
        {
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRight(10, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRight(1, 10, 1));
            Assert.ThrowsException<ArgumentException>(() => Triangle.IsRight(1, 1, 10));
        }

        /// <summary>
        /// Tests if triangle is right calculation
        /// </summary>
        [TestMethod()]
        public void NormalIsRightTest()
        {
            Assert.AreEqual(true, Triangle.IsRight(3, 4, 5));
            Assert.AreEqual(false, Triangle.IsRight(3, 4, 6));
        }
        #endregion
    }
}
