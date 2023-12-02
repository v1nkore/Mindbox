using FigureExtensions.Abstractions;

namespace FigureExtensions.Figures
{
	public class Triangle : Figure
	{
		private const double Tolerance = 1e-17;

		/// <summary>
		/// First side of the triangle
		/// </summary>
		public double SideA { get; }

		/// <summary>
		/// Second side of the triangle
		/// </summary>
		public double SideB { get; }

		/// <summary>
		/// Hypotenuse of the triangle
		/// </summary> 
		public double Hypotenuse { get; }

		public Triangle(double sideA, double sideB, double hypotenuse)
		{
			if (!Exists(sideA, sideB, hypotenuse))
			{
				throw new ArgumentException("Triangle doesn't exist. Sum of any two sides must be greater than third");
			}

			SideA = sideA;
			SideB = sideB;
			Hypotenuse = hypotenuse;
		}

		/// <summary>
		/// Checks the conditions for the existence of a triangle
		/// </summary>
		/// <param name="sideA">First side of the triangle</param>
		/// <param name="sideB">Second side of the triangle</param>
		/// <param name="hypotenuse">Hypotenuse of the triangle</param>
		public static bool Exists(double sideA, double sideB, double hypotenuse)
		{
			return
				sideA + sideB > hypotenuse
				&& sideB + hypotenuse > sideA
				&& sideA + hypotenuse > sideB;
		}

		/// <summary>
		/// Calculates area of the triangle
		/// </summary>
		/// <param name="digits">Number of digits after comma</param>
		/// <returns>Area of the triangle</returns>
		public override double CalculateArea(int? digits = null)
		{
			var semiPerimeter = (SideA + SideB + Hypotenuse) / 2;
			var area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - Hypotenuse));

			return digits.HasValue ? Math.Round(area, digits.Value) : area;
		}

		public bool IsRight()
		{
			return Math.Abs(Math.Pow(Hypotenuse, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideB, 2))) < Tolerance;
		}
	}
}
