namespace homeworks
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int a = 0;
			int b = 0;
			int c = 0;
			int d = 0;
			List<double> listWithX = new List<double>();
			try
			{
				Console.WriteLine("Введите значение a: ");
				a = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите значение b: ");
				b = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите значение c: ");
				c = int.Parse(Console.ReadLine());
			}

			catch (Exception ex)
			{
				Console.WriteLine("Введено некорректное значение \n" + ex);
			}
			d = Discriminant(a, b, c);
			listWithX = XFinder(a, b, d);
			foreach (double list in listWithX)
			{
				Console.WriteLine(list);
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
				else if (d < 0)
				{
					/*return;*/
				}

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
			return result;
		}
		
	}
}