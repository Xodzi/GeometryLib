using GeometryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibTests
{
    internal class TriangleTests
    {
        [Test]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            double actualArea = triangle.CalculateArea();
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [Test]
        public void TestIsRightTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);

            bool isRightTriangle = rightTriangle.IsRightTriangle();

            Assert.IsTrue(isRightTriangle);
        }
        [Test]
        public void TestIsNotRightTriangleCheck()
        {
            Triangle nonRightTriangle = new Triangle(3, 4, 6);

            bool isNonRightTriangle = nonRightTriangle.IsRightTriangle();

            Assert.IsFalse(isNonRightTriangle);
        }
    }
}
