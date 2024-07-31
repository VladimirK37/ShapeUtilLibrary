using ShapeUtilLibrary;

namespace ShapeUtilLibraryTest
{
    public class TriangleTest
    {
        [Fact]
        public void Triangle_GetArea()
        {
            //Arrange
            Triangle triangle = new Triangle(2, 4, 5);
            double halfPerimeterTest = (double)(2 + 4 + 5) / 2;
            double expected = Math.Sqrt(halfPerimeterTest * (halfPerimeterTest - 2) * (halfPerimeterTest - 4) * (halfPerimeterTest - 5));

            //Act
            double actual = triangle.GetArea();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_GetAreaException()
        {
            //Arrange
            Triangle triangle = new Triangle(0, 0, 0);

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => triangle.GetArea());
        }

        [Fact]
        public void Triangle_IsValidNegativeNumber()
        {
            //Arrange
            Triangle triangle = new Triangle(-1, -5, -7);

            //Act
            bool actual = triangle.IsValid();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Triangle_IsValidNaN()
        {
            //Arrange
            Triangle triangle = new Triangle(double.NaN, -5, double.NaN);

            //Act
            bool actual = triangle.IsValid();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Triangle_IsValidTrue()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 6);

            //Act
            bool actual = triangle.IsValid();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Triangle_IsRightTriangle()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //Act
            bool actual = triangle.IsRightTriangle();

            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void Triangle_IsRightTriangleFalse()
        {
            //Arrange
            Triangle triangle = new Triangle(2, 2, 3);

            //Act
            bool actual = triangle.IsRightTriangle();

            //Assert
            Assert.False(actual);
        }
    }
}
