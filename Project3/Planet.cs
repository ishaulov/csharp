namespace Project3;

public class Planet
{
	private string _name = string.Empty;
	private int _orderNumberFromTheSun = 0;
	private int _equatorLength = 0;
	private string _previousPlanet = string.Empty;

	private List<string> _planetsList = new List<string>
		{ "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };


	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	public int OrderNumberFromTheSun
	{
		get { return _orderNumberFromTheSun; }
		set { _orderNumberFromTheSun = value; }
	}

	public int EquatorLength
	{
		get { return _equatorLength; }

		set { _equatorLength = value; }
	}

	public string PreviousPlanet
	{
		get { return _previousPlanet; }
		set { _previousPlanet = value; }
	}

	public Planet(string name, int orderNumberFromTheSun, int equatorLength)
	{
		Name = name;
		OrderNumberFromTheSun = orderNumberFromTheSun;
		EquatorLength = equatorLength;
		if (orderNumberFromTheSun == 1)
		{
			PreviousPlanet = "SUN!!!";
		}
		else
		{
			PreviousPlanet = _planetsList[orderNumberFromTheSun - 2];
		}
	}
}