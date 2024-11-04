namespace myfirstapp
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int n;

			while (true)
			{
				Console.Write("Enter a number between 1 and 6: ");
				string input = Console.ReadLine();

				if (int.TryParse(input, out n))
				{
					if (n is < 1 or > 6)
					{
						Console.WriteLine("Warning! Enter a number between 1 and 6: ");
					}
					else
					{
						break;
					}
				}
				else
				{
					Console.WriteLine("Error! This is not a number.");
				}
			}

			Console.WriteLine($"You enter the number: {n}");

			string s;

			while (true)
			{
				Console.Write("Enter a random text: ");
				s = Console.ReadLine();

				if (string.IsNullOrWhiteSpace(s))
				{
					break;
				}
			}

			Console.WriteLine($"You enter the text: {s}");

			WriteTable(n, s);
		}

		private static void WriteTable(int n, string s)
		{
			int wight = s.Length + 2 * (n - 1);
			int height = 2 * n - 1;

			if (wight > 40)
			{
				return;
			}

			CrossLine(wight);

			for (int i = 1; i <= 2 * n - 1; i++)
			{
				Console.Write('+');
				if (i == n)
				{
					for (int j = 1; j <= n - 1; j++)
					{
						Console.Write(' ');
					}

					Console.Write(s);
					for (int j = 1; j <= n - 1; j++)
					{
						Console.Write(' ');
					}
				}
				else
				{
					for (int j = 1; j <= wight; j++)
					{
						Console.Write(' ');
					}
				}

				Console.Write('+');
				Console.Write('\n');
			}

			CrossLine(wight);
			ChessDeck(wight, height);
			CrossLine(wight);
			BigCross(wight);
			CrossLine(wight);
		}

		private static void CrossLine(int wight)
		{
			for (int i = 1; i <= wight + 2; i++)
			{
				Console.Write('+');
			}

			Console.WriteLine();
		}

		public static void ChessDeck(int width, int height)
		{
			for (int j = 0; j < height; j++)
			{
				Console.Write("+");

				for (int k = 0; k < width; k++)
				{
					if ((j + k) % 2 == 0)
					{
						Console.Write("+");
					}
					else
					{
						Console.Write(" ");
					}
				}

				Console.Write("+");
				Console.WriteLine();
			}
		}

		public static void BigCross(int wight)
		{
			for (int i = 0; i < wight; i++)
			{
				Console.Write("+");
				for (int j = 0; j < wight; j++)
				{
					if (j == i)
					{
						Console.Write('+');
					}
					else if (j == wight - i - 1)
					{
						Console.Write('+');
					}
					else
					{
						Console.Write(' ');
					}
				}

				Console.Write("+");
				Console.WriteLine();
			}
		}
	}
}