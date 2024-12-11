namespace Project3;

public class Planet
{
	private string _name = string.Empty;
	private int _orderNumberFromTheSun = 0;
	private int _equatorLength = 0;

	public string Name
	{
		get
		{
			return _name;
		}
		set
		{
			_name = value;
		}
	}

	public int OrderNumberFromTheSun
	{
		get
		{
			return _orderNumberFromTheSun;
		}
		set
		{
			_orderNumberFromTheSun = value;
		}
	}

	public int EquatorLength
	{
		get
		{
			return _equatorLength;
		}

		set
		{
			_equatorLength = value;
		}
	}

	public Planet(string name, int orderNumberFromTheSun, int equatorLength)
	{
		Name = name;
		OrderNumberFromTheSun = orderNumberFromTheSun;
		EquatorLength = equatorLength;
		
	}
}