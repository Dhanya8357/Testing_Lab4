using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traingle_Test;
using NUnit.Framework;



namespace Testclass
{
    public class TriangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]
            public void ValidTriangles_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int first_angle = 60;
                int second_angle = 60;
                int third_angle = 60;
                string expected = "The triangle is valid";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void ValidTriangles_Input40and60and50_OutputValidTriangle()
            {
                //Arrange
                int first_angle = 40;
                int second_angle = 60;
                int third_angle = 50;
                string expected = "The triangle is NOT valid";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void ValidTriangles_Input90and30and60_OutputValidTriangle()
            {
                //Arrange
                int first_angle = 90;
                int second_angle = 30;
                int third_angle = 60;
                string expected = "The triangle is valid";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            [Test]
            public void ValidTriangles_Input80and30and60_OutputValidTriangle()
            {
                //Arrange
                int first_angle = 80;
                int second_angle = 30;
                int third_angle = 60;
                string expected = "The triangle is NOT valid";

                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}


