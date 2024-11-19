namespace homeworks;

public class Quadratic
{
	class Variables
	{
		public static int ArgA { get; set; }
		public static int ArgB { get; set; }
		public static int ArgC { get; set; }
	}

	public void SetArguments()
	{
		var a = Variables.ArgA;
		var b = Variables.ArgB;
		var c = Variables.ArgC;

		while (true)
		{
			try
			{
				Console.WriteLine("Введите значение a: ");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите значение b: ");
				b = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите значение c: ");
				c = int.Parse(Console.ReadLine());

				break;
			}

			catch (Exception ex)
			{
				Console.WriteLine("Введено некорректное значение \n" + ex);
			}
		}

		List<double> listWithX = new List<double>();
		listWithX = XFinder(a, b, Discriminant(a, b, c));
		if (listWithX.Count == 2)
		{
			Console.WriteLine($"x1 = {listWithX[0]}, x2 = {listWithX[1]}");
		}
		else if (listWithX.Count == 1)
		{
			Console.WriteLine($"x = {listWithX[0]}");
		}
	}

	public static int Discriminant(int a, int b, int c)
	{
		int d;

		try
		{
			d = checked(b * b - 4 * a * c);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception: \n" + ex);
			return 0;
		}

		return d;
	}

	public static List<double> XFinder(int a, int b, int d)
	{
		double x1 = 0;
		double x2 = 0;
		List<double> result = new List<double>();

		try
		{
			if (d > 0)
			{
				x1 = (-b + Math.Sqrt(d)) / 2 * a;
				x2 = (-b - Math.Sqrt(d)) / 2 * a;
				result.Add(x1);
				result.Add(x2);
			}
			else if (d == 0)
			{
				x1 = (-b + Math.Sqrt(d)) / 2 * a;
				result.Add(x1);
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.Yellow;
				Console.ForegroundColor = ConsoleColor.Black;
				throw new Exclude("Вещественных значений не найдено");
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("Bright lies \n" + e);
			throw;
		}

		return result;
	}
}