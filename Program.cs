using System;

namespace ConsoleAppProject
{
	/// <summary>
	/// This Project has been modified by:
	/// Mustafa Akram 05/03/2023
	/// </summary>
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine();
			Console.WriteLine(" =================================================");
			Console.WriteLine("    Distance Converter! By: Mustafa Akram ");
			Console.WriteLine(" =================================================");
			Console.WriteLine();

			double metersToMiles = 0.000621371;

			double milesToFeet = 5280;

			Console.WriteLine("Please choose the unit by typing the assigned number:");
			Console.WriteLine("1. Miles");
			Console.WriteLine("2. Feet");
			Console.WriteLine("3. Meters");

			Console.Write("Type distance in meters:");
			double meters = Convert.ToDouble(Console.ReadLine());

			double miles = meters * metersToMiles;
			Console.WriteLine("{0} meters is {1} miles", meters, miles);

			Console.Write("Enter distance in miles: ");
			double milesInput = Convert.ToDouble(Console.ReadLine());

			double feet = milesInput * milesToFeet;
			Console.WriteLine("{0} miles is {1} feet", milesInput, feet);

		}

	}
}
