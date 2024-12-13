namespace Project2;

public class CatalogOfPlanets
{
	private string[] _planets;

	//public static GetPlanet()
	private int _count = 0;

	public CatalogOfPlanets()
	{
		_planets = ["Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"];
	}

	
	public (int, int, string) GetPlanet(string planetName)
	{
		_count += 1;
		if (_count % 3 == 0)
		{
			return (0, 0, "Вы спрашиваете слишком часто");
		}

		switch (planetName)
		{
			case "Mercury":
				return (1, 4880 , "Mercury");
			case "Venus":
				return (2, 38025, "Venus");
			case "Earth":
				return (3, 40075, "Earth");
			case "Mars":
				return (4, 21344, "Mars");
			case "Jupiter":
				return (5, 439264, "Jupiter");
			case "Saturn":
				return (6, 60268, "Saturn");
			case "Uranus":
				return (7, 25559, "Uranus");
			case "Neptune":
				return (8, 48682, "Neptune");
			default:
				return (0, 0, "Не удалось найти планету");
		}
	}
}