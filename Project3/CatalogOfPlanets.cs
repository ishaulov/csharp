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

	public delegate void PlanetValidator(string planetName);
	public void CountOfCall(string planetName)
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
			Console.WriteLine("Вы спрашиваете слишком часто");
			_count = 1; 
		}
	}

	public (string, int, int) GetPlanet(string planetName, PlanetValidator planetValidator)
	{
		planetValidator(planetName);
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