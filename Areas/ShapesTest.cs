using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Areas
{
    [TestFixture]
    class ShapesTest
    {
        [Test]
        public void CircleAreaTest()
        {
            Circle a = new Circle();
            double x = 4.0;
            double expectedValue = Math.PI * 16;
            double actualValue = a.Area(x);
            Assert.AreEqual(expectedValue, actualValue);

        }
        [Test]
        public void CirclePerimeterTest()
        {
            Circle a = new Circle();
            double x = 4.0;
            double expectedValue = 2 * Math.PI * 4;
            double actualValue = a.Perimeter(x);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void RectangleAreaTest()
        {
            Rectangle a = new Rectangle();
            double x = 4.0;
            double y = 6.0;
            double expectedValue = 24;
            double actualValue = a.Area(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void RectanglePerimeterTest()
        {
            Rectangle a = new Rectangle();
            double x = 4.0;
            double y = 6.0;
            double expectedValue = 20;
            double actualValue = a.Perimeter(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]

        public void TriangeAreaTest()
        {
            Triangle a = new Triangle();
            double x = 4;
            double y = 3;
            double z = 5;
            double expectedValue = 6;
            double actualValue = a.Area(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]

        public void TrianglePerimeterTest()
        {
            Triangle a = new Triangle();
            double x = 4;
            double y = 3;
            double z = 5;
            double expectedValue = 12;
            double actualValue = a.Perimeter(x, y, z);
            Assert.AreEqual(expectedValue, actualValue);
        }



    }
}
