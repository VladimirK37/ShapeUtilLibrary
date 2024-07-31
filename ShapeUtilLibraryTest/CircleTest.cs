using ShapeUtilLibrary;

namespace ShapeUtilLibraryTest
{
    public class CircleTest
    {
        [Fact]
        public void Circle_GetArea()
        {
            //Arrange
            Circle circle = new Circle(5.8);
            double expected = Math.PI * Math.Pow(5.8, 2);

            //Act
            double actual = circle.GetArea();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Circle_GetAreaExepction()
        {
            //Arrange
            Circle circle = new Circle(0);

            //Act

            //Assert
            Assert.Throws<ArgumentException>(() => circle.GetArea());
        }

        [Fact]
        public void Circle_IsValidNegativeNumber()
        {
            //Arrange
            Circle circle = new Circle(-1);

            //Act
            bool actual = circle.IsValid();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Circle_IsValidNaN()
        {
            //Arrange
            Circle circle = new Circle(double.NaN);

            //Act
            bool actual = circle.IsValid();

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Circle_IsValidCorrectValue()
        {
            //Arrange
            Circle circle = new Circle(5);

            //Act
            bool actual = circle.IsValid();

            //Assert
            Assert.True(actual);
        }
    }
}