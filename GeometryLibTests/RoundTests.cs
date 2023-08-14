using GeometryLib;

namespace GeometryLibTests
{
    public class RoundTests
    {

        [Test]
        public void TestCircleArea()
        {
            Round circle = new Round(5);
            double expectedArea = Math.PI * 5 * 5;
            double actualArea = circle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }
    }
}