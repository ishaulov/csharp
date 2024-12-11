namespace Project3;

public class CatalogOfPlanets
{
	private string[] _planets;

	//public static GetPlanet()
	private int _count = 0;

	public CatalogOfPlanets()
	{
		_planets = ["Venus", "Earth", "Mars"];
	}

	
	public (string, int, int) GetPlanet(string planetName)
	{
		_count += 1;
		if (_count % 3 == 0)
		{
			Console.WriteLine("Вы спрашиваете слишком часто");
		}

		switch (planetName)
		{
			case "Venus":
				return ("Venus", 2, 38025);
			case "Earth":
				return ("Earth", 3, 40075);
			case "Mars":
				return ("Mars", 4, 21344);
			default:
				return ("Не удалось найти планету", 0, 0);
		}
	}
}