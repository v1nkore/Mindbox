using FigureExtensions.Abstractions;

namespace FigureExtensions.Figures
{
	public class Circle : Figure
	{
		/// <summary>
		/// Radius of the circle
		/// </summary>
		public double Radius { get; }

		public Circle(double radius)
		{
			if (!IsValid(radius))
			{
				throw new ArgumentException("Radius of circle must be greater than zero");
			}

			Radius = radius;
		}

		/// <summary>
		/// Checks the conditions for the existence of a circle
		/// </summary>
		/// <param name="radius">Radius of the circle</param>
		public static bool IsValid(double radius) => radius > 0;

		/// <summary>
		/// Calculates area of the circle
		/// </summary>
		/// <param name="digits">Number of digits after comma</param>
		/// <returns>Area of the circle</returns>
		public override double CalculateArea(int? digits = null)
		{
			var area = Math.PI * Math.Pow(Radius, 2);

			return digits.HasValue ? Math.Round(area, digits.Value) : area;
		}
	}
}
