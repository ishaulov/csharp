namespace Project3;

class Program
{
	static void Main(string[] args)
	{
		CatalogOfPlanets catalog = new CatalogOfPlanets();
		Console.WriteLine(catalog.GetPlanet("Venus"));
		Console.WriteLine(catalog.GetPlanet("Limonia"));
		catalog.GetPlanet("Venus");
		catalog.GetPlanet("Venus");

	}
}