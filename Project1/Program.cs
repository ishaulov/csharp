namespace Project1;

class Program
{
	static void Main(string[] args)
	{
		var Venus = new
		{
			Name = "Venus",
			orderNumberFromTheSun = 2,
			equatorLength = 38025,
			previousPlanet = "Empty"
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

		var VenusAgain = new
		{
			Name = "Venus",
			orderNumberFromTheSun = 2,
			equatorLength = 38025,
			previousPlanet = "Empty"
		};

		Console.WriteLine(Venus);
		Console.WriteLine(Earth);
		Console.WriteLine(Mars);
		Console.WriteLine(Venus.Equals(VenusAgain));
		Console.WriteLine(Earth.Equals(VenusAgain));
		Console.WriteLine(Mars.Equals(VenusAgain));
	}
}