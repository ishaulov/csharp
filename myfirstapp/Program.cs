﻿namespace myfirstapp
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введите значение a: ");
				int a = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите значение b: ");
				int b = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите значение c: ");
				int c = int.Parse(Console.ReadLine());

				int d = b * b - 4 * a * c;
				
				Console.WriteLine(Discriminant(a, b, c));
			}

			catch (Exception ex)
			{
				Console.WriteLine("Введено некорректное значение \n" + ex);
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
	}
}