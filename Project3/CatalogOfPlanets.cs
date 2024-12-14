namespace Project3;

public class CatalogOfPlanets
{
	private string[] _planets;
	private int _count = 0;
	private string _currentPlanet = String.Empty;
	//public static GetPlanet()


	public CatalogOfPlanets()
	{
		_planets = ["Venus", "Earth", "Mars"];
	}

	public delegate string PlanetValidator(string planetName);

	public string CountOfCall(string planetName)
	{
		if (planetName == _currentPlanet)
		{
			_count += 1;
		}
		else
		{
			_currentPlanet = planetName;
			_count = 0;
		}

		if (_count == 3)
		{
			_count = 0;
			return "Вы спрашиваете слишком часто";
		}

		return null;
	}

	public (int, int, string) GetPlanet(string planetName, PlanetValidator planetValidator)
	{
		string validation = planetValidator(planetName);
		if (validation == "deny")
		{
			return (0, 0, "Это запретная планета");
		}

		switch (planetName)
		{
			case "Mercury":
				return (1, 4880, validation);
			case "Venus":
				return (2, 38025, validation);
			case "Earth":
				return (3, 40075, validation);
			case "Mars":
				return (4, 21344, validation);
			case "Jupiter":
				return (5, 439264, validation);
			case "Saturn":
				return (6, 60268, validation);
			case "Uranus":
				return (7, 25559, validation);
			case "Neptune":
				return (8, 48682, validation);
			default:
				return (0, 0, "Не удалось найти планету");
		}
	}
}