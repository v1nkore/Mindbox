using FigureExtensions.Figures;

namespace FigureExtensions.UnitTests.Tests
{
	public class TriangleTests
	{
		[Theory]
		[InlineData(3, 4, 5)]
		public void Constructor_ShouldReturnInstanceReference_WhenCanExist(double sideA, double sideB, double hypotenuse)
		{
			// Arrange
			var triangle = new Triangle(sideA, sideB, hypotenuse);

			// Act

			// Assert
			Assert.Equal(sideA, triangle.SideA);
			Assert.Equal(sideB, triangle.SideB);
			Assert.Equal(hypotenuse, triangle.Hypotenuse);
		}

		[Theory]
		[InlineData(3, 4, 8)]
		public void Constructor_ShouldReturnInstanceReference_WhenDoesNotExists(double sideA, double sideB, double hypotenuse)
		{
			// Arrange

			// Act

			// Assert
			Assert.Throws<ArgumentException>(() => _ = new Triangle(sideA, sideB, hypotenuse));
		}

		[Theory]
		[InlineData(3, 4, 5, 1, 6)]
		[InlineData(3.3, 4.4, 5.5, 1, 7.3)]
		public void CalculateArea_ShouldReturnRoundedArea_WhenRadiusGreaterThenZeroAndDigitsNotNull(double sideA, double sideB, double hypotenuse, int digits, double expectedArea)
		{
			// Arrange
			var triangle = new Triangle(sideA, sideB, hypotenuse);

			// Act
			var area = triangle.CalculateArea(digits);

			// Assert
			Assert.Equal(expectedArea, area);
		}

		[Theory]
		[InlineData(3, 4, 5, 6)]
		[InlineData(3.3, 4.4, 5.5, 7.2599999999999971)]
		public void CalculateArea_ShouldReturnArea_WhenDigitsNotNull(double sideA, double sideB, double hypotenuse, double expectedArea)
		{
			// Arrange
			var triangle = new Triangle(sideA, sideB, hypotenuse);

			// Act
			var area = triangle.CalculateArea();

			// Assert
			Assert.Equal(expectedArea, area);
		}

		[Theory]
		[InlineData(3, 4, 5)]
		public void IsRight_ShouldReturnTrue_WhenTriangleIsRight(double sideA, double sideB, double hypotenuse)
		{
			// Arrange
			var triangle = new Triangle(sideA, sideB, hypotenuse);

			// Act
			
			// Assert
			Assert.True(triangle.IsRight());
		}

		[Theory]
		[InlineData(3, 4, 6)]
		public void IsRight_ShouldReturnFalse_WhenTriangleNotRight(double sideA, double sideB, double hypotenuse)
		{
			// Arrange
			var triangle = new Triangle(sideA, sideB, hypotenuse);

			// Act

			// Assert
			Assert.False(triangle.IsRight());
		}
	}
}
