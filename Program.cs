
Console.WriteLine("Hello, World!");
public class Programming

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
