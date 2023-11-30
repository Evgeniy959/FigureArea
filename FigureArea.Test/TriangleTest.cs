namespace FigureArea.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void CalcArea_ThreeParameter_ReturnsArea()
        {
            double expected = 34.641;            
            var actual = new Triangle().CalcArea(7, 10, 13);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRectangular_ThreeParameter_ReturnsTrueOrFalse()
        {
            var actualFalse = new Triangle().IsRectangular(7, 10, 13);
            var actualTrue = new Triangle().IsRectangular(20, 15, 25);

            Assert.IsFalse(actualFalse);
            Assert.IsTrue(actualTrue);
        }

        [TestMethod]
        public void CalcArea_Exception()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(0, 10, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(10, 0, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(10, 10, 0));
                                                            
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(-10, 10, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(10, -10, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(10, 10, -10));
                                                            
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(10, 20, 40));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(40, 10, 20));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().CalcArea(20, 40, 10));
        }

        [TestMethod]
        public void IsRectangular_Exception()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(0, 10, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(10, 0, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(10, 10, 0));
                                                             
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(-10, 10, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(10, -10, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(10, 10, -10));
                                                             
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(10, 20, 40));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(40, 10, 20));
            Assert.ThrowsException<ArgumentException>(() => new Triangle().IsRectangular(20, 40, 10));
        }
    }
}