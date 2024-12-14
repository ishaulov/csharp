namespace Project3;

class Program
{
	static void Main(string[] args)
	{

		Planet venus = new Planet("Venus", 2, 36000);
		Planet earth = new Planet("Earth", 3, 42000);
		Planet mercury = new Planet("Mercury", 1, 42000);
		Planet neptune = new Planet("Neptune", 8, 42000);
		CatalogOfPlanets catalogOfPlanets = new CatalogOfPlanets();
		string currentPlanet = string.Empty;
		int count = 1;
		
		catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall);
		CatalogOfPlanets.PlanetValidator Lyamda = (string planetName) =>
		{
			if (planetName == currentPlanet)
			{
				count += 1;
			}
			else
			{
				currentPlanet = planetName;
				count = 1;
			
			}
			if (count == 3)
			{
				count = 0; 
				return "Вы спрашиваете слишком часто";
			
			}
			return null;
		};
		
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", Lyamda));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", Lyamda));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", Lyamda));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", Lyamda));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", Lyamda));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", Lyamda));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", Lyamda));
		Console.WriteLine("---------------------------------------------------------------");
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		
	}
	
}