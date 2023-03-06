using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
	/// <summary>
	/// The main method in this class is called first
	/// when the application is started.  It will be used
	/// to start App01 to App05 for CO453 CW1
	/// 
	/// This Project has been modified by:
	/// Mustafa Akram 05/03/2023
	/// </summary>
	class Program

{
	static void Main(string[] args)
	{

		double metersToMiles = 0.000621371;

		double milesToFeet = 5280;

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
