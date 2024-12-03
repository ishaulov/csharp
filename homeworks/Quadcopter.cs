namespace homeworks;

public class Quadcopter : IFlyingRobot, IChargeable
{
	private static List<string> _components;

	public void Charge()
	{
		Console.WriteLine("Charging...");
		Thread.Sleep(3000);
		Console.WriteLine("Charged!");
	}

	public string GetInfo()
	{
		return "WARNING! Battery low!";
	}

	public List<string> GetComponents(params string[] components)
	{
		_components = new List<string>(components);
		return _components;
	}

	public void PrintComponents()
	{
		foreach (string component in _components)
			Console.Write(component + " ");
		Console.WriteLine();
	}

	public string GetRobotType()
	{
		return "I am a Dron.";
	}

	public string GetRobotName()
	{
		return "My name is QuadroRobert.";
	}
}