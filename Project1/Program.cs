namespace Project1;

class Program
{
	static void Main(string[] args)
	{
		// Console.WriteLine("Hello, World!");

		var Venus = new
		{
			Name = "Venus",
			orderNumberFromTheSun = 2,
			equatorLength = 38025
		};

		var Earth = new
		{
			Name = "Earth",
			orderNumberFromTheSun = 3,
			equatorLength = 40075,
			previousPlanet = Venus
		};

		var Mars = new
		{
			Name = "Mars",
			orderNumberFromTheSun = 4,
			equatorLength = 21344,
			previousPlanet = Earth
		};

		Console.WriteLine(Venus);
		Console.WriteLine(Earth);
	}
}