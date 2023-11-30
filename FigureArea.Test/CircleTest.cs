namespace FigureArea.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalcArea_OneParameter_ReturnsArea()
        {
            double expected = 706.858;            
            var actual = new Circle().CalcArea(15);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcArea_Exception()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle().CalcArea(0));
            Assert.ThrowsException<ArgumentException>(() => new Circle().CalcArea(-1));
        }

    }
}