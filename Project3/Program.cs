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
		
		catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall);
		
		
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		Console.WriteLine(catalogOfPlanets.GetPlanet("Venus", catalogOfPlanets.CountOfCall));
		
	}
	
}