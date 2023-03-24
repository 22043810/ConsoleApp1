using System;

namespace ConsoleAppProject
{
	/// <summary>
	/// This Project has been modified by:
	/// Mustafa Akram 05/03/2023
	/// </summary>
	public class Program 
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.WriteLine();
			Console.WriteLine(" =================================================");
			Console.WriteLine("    Distance Converter! By: Mustafa Akram ");
			Console.WriteLine(" =================================================");
			Console.WriteLine();

			Console.WriteLine("Please select your From unit:");
			Console.WriteLine("1. Miles");
			Console.WriteLine("2. Feet");
			Console.WriteLine("3. Meters");
			Console.WriteLine();

			Console.WriteLine("Kindly enter your choice:");

			string fromUnit = Console.ReadLine();

			Console.WriteLine("Please select your To unit:");
			Console.WriteLine("1. Miles");
			Console.WriteLine("2. Feet");
			Console.WriteLine("3. Meters");
			Console.WriteLine();

			Console.WriteLine("Kindly enter your choice:");

			string toUnit = Console.ReadLine();

			Console.WriteLine("Enter the distance:");

			double distance = double.Parse(Console.ReadLine());

			double convertedDistance = ConvertDistance(fromUnit, toUnit, distance);

			Console.WriteLine("{0} {1} is equal to {2} {3}.", distance, GetUnitName(fromUnit), convertedDistance, GetUnitName(toUnit));

			Console.WriteLine("Did you enjoy the app? (Yes/No)");

			string answer = Console.ReadLine().ToUpper();

			if (answer == "YES" || answer == "Y")
			{
				Console.WriteLine("Since you enjoyed using the app, why not follow us on social media @....");
			}
			else
			{
				Console.WriteLine("Kindly give us your feedback so we can make improvements.");
			}

			Console.WriteLine("Thank you for using the Distance Converter App!");
		}

		static double ConvertDistance(string fromUnit, string toUnit, double distance)
		{
			switch (fromUnit)
			{
				case "1": // miles
					switch (toUnit)
					{
						case "2": // miles to feet
							return distance * 5280;
						case "3": // miles to meters
							return distance * 1609.34;
						default: // miles to miles
							return distance;
					}
				case "2": // feet
					switch (toUnit)
					{
						case "1": // feet to miles
							return distance / 5280;
						case "3": // feet to meters
							return distance / 3.28084;
						default: // feet to feet
							return distance;
					}
				case "3": // meters
					switch (toUnit)
					{
						case "1": // meters to miles
							return distance / 1609.34;
						case "2": // meters to feet
							return distance * 3.28084;
						default: // meters to meters
							return distance;
					}
				default: // invalid input
					return 0;
			}
		}

		static string GetUnitName(string unit)
		{
			switch (unit)
			{
				case "1":
					return "miles";
				case "2":
					return "feet";
				case "3":
					return "meters";
				default:
					return "";
			}
		}
	}
}
