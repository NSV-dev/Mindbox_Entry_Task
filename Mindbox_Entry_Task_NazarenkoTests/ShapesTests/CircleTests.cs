using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox_Entry_Task_Nazarenko;
using Mindbox_Entry_Task_Nazarenko.Shapes;

namespace Mindbox_Entry_Task_NazarenkoTests.ShapesTests
{
    [TestClass()]
    public class CircleTests
    {
        /// <summary>
        /// Tests negative input
        /// </summary>
        [TestMethod()]
        public void NegativeCalculateTest() => Assert.ThrowsException<ArgumentOutOfRangeException>(() => Circle.Calculate(-10));

        /// <summary>
        /// Tests circle area calculation
        /// </summary>
        [TestMethod()]
        public void NormalCalculateTest() => Assert.AreEqual(12.57, AreaCalculator.AreaBySides(2));
    }
}
