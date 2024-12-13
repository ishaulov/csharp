namespace Project2;

public class CatalogOfPlanets
{
	private string[] _planets;

	//public static GetPlanet()
	private int _count = 0;

	public CatalogOfPlanets()
	{
		_planets = ["Venus", "Earth", "Mars"];
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
			case "Venus":
				return (2, 38025,"Venus");
			case "Earth":
				return (3, 40075, "Earth");
			case "Mars":
				return (4, 21344, "Mars");
			default:
				return (0, 0, "Не удалось найти планету");
		}
	}
}