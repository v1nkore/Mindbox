using FigureExtensions.Figures;

namespace FigureExtensions.UnitTests.Tests
{
    public class CircleTests
    {
		[Theory]
		[InlineData(42)]
		[InlineData(52.2)]
	    public void Constructor_ShouldReturnInstanceReference_WhenRadiusGreaterThenZero(double radius)
	    {
			// Arrange
			var circle = new Circle(radius);

			// Act

			// Assert
			Assert.Equal(radius, circle.Radius);
	    }

	    [Theory]
	    [InlineData(0)]
	    [InlineData(-1)]
	    [InlineData(-5.15)]
	    public void Constructor_ShouldThrowArgumentException_WhenRadiusLessOrEqualZero(double radius)
	    {
		    // Arrange

		    // Act

		    // Assert
		    Assert.Throws<ArgumentException>(() => _ = new Circle(radius));
	    }

		[Theory]
	    [InlineData(1, 3.14, 2)]
	    [InlineData(3.2, 32.1699, 4)]
	    public void CalculateArea_ShouldReturnRoundedArea_WhenDigitsNotNull(double radius, double expectedArea, int digits)
	    {
			// Arrange
		    var circle = new Circle(radius);

			// Act
			var area = circle.CalculateArea(digits);

			// Assert
			Assert.Equal(expectedArea, area);
	    }

	    [Theory]
	    [InlineData(1, 3.1415926535897931)]
	    [InlineData(3.2, 32.169908772759484)]
	    public void CalculateArea_ShouldReturnArea_WhenRadiusGreaterThenZero(double radius, double expectedArea)
	    {
		    // Arrange
		    var circle = new Circle(radius);

		    // Act
		    var area = circle.CalculateArea();

		    // Assert
		    Assert.Equal(expectedArea, area);
	    }
    }
}
