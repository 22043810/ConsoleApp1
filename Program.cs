using System;

namespace ConsoleAppProject
{
	/// 
	/// This Project has been modified by:
	/// Mustafa Akram 05/03/2023
	/// 
	static class Program
	{
	

		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine();
			Console.WriteLine(" =================================================");
			Console.WriteLine("    Distance Converter! By: Mustafa Akram ");
			Console.WriteLine(" =================================================");
			Console.WriteLine();

			Console.WriteLine("This converter can be used for the following conversions:");
			Console.WriteLine("1. Meters to Miles");
			Console.WriteLine("2. Kilometers to centimeters");
			Console.WriteLine("3. Miles to Feet");

			double metersToMiles = 0.000621371;

			double kilometersToCentimeters = 10000;

			double milesToFeet = 5280;


			Console.Write("Type distance in meters:");
			double meters = Convert.ToDouble(Console.ReadLine());

			double miles = meters * metersToMiles;
			Console.WriteLine("{0} meters is {1} miles", meters, miles);

			Console.Write("Enter distance in kilometers: ");
			double kilometersInput = Convert.ToDouble(Console.ReadLine());

			double centimeters = kilometersInput * kilometersToCentimeters;
			Console.WriteLine("{0} kilometers is {1} centimeters", kilometersInput, centimeters);

			Console.Write("Enter distance in miles: ");
			double milesInput = Convert.ToDouble(Console.ReadLine());

			double feet = milesInput * milesToFeet;
			Console.WriteLine("{0} miles is {1} feet", milesInput, feet);

			Console.WriteLine("Did you enjoy the app? (Yes/No)");
			string answer = Console.ReadLine().ToUpper();

			if (answer == "Y")

			{
				Console.WriteLine("since you enjoyed using the app why not follow us on social media @...." );
			}
			else
			{
				Console.WriteLine("kindly give us your feed back so we can make improvements");
			}

			Console.WriteLine("Thank you for using Distance Converter App!");
		}

	}

}

