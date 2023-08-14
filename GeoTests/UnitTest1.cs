namespace GeoTests
{
    public class GeometryTests
    {
        [Test]
        public void TestCircleArea()
        {
            Circle circle = new Circle(5);
            double expectedArea = Math.PI * 5 * 5;
            double actualArea = circle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            double actualArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void TestRightTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Triangle nonRightTriangle = new Triangle(3, 4, 6);

            bool isRightTriangle = rightTriangle.IsRightTriangle();
            bool isNonRightTriangle = nonRightTriangle.IsRightTriangle();

            Assert.IsTrue(isRightTriangle);
            Assert.IsFalse(isNonRightTriangle);
        }
    }
}