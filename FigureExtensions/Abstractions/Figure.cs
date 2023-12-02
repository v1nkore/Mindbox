namespace FigureExtensions.Abstractions
{
	public abstract class Figure
	{
		/// <summary>
		/// Calculates area of the figure
		/// </summary>
		/// <param name="digits">Number of digits after comma</param>
		/// <returns>Area of the figure</returns>
		public abstract double CalculateArea(int? digits = null);
	}
}
