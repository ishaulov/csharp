namespace Project2;

class Program
{
	static void Main(string[] args)
	{
		/*CatalogOfPlanets catalog = new CatalogOfPlanets();
		Console.WriteLine(catalog.GetPlanet("Venus"));
		Console.WriteLine(catalog.GetPlanet("Limonia"));
		catalog.GetPlanet("Venus");
		catalog.GetPlanet("Venus");*/

		Planet venus = new Planet("Venus", 2, 36000);
		Planet earth = new Planet("Earth", 3, 42000);
		Planet mercury = new Planet("Mercury", 1, 42000);
		Planet neptune = new Planet("Neptune", 8, 42000);
		
		Console.WriteLine(venus.PreviousPlanet);
		Console.WriteLine(earth.PreviousPlanet);
		Console.WriteLine(mercury.PreviousPlanet);
		Console.WriteLine(neptune.PreviousPlanet);
	}
}