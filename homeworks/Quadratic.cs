namespace homeworks;

public class Quadratic
{
	public int ArgA {get; set;}
	public int ArgB {get; set;}
	public int ArgC {get; set;}

	public void SetArguments()
	{
		while (true)
		{
			try
			{
				Console.WriteLine("Введите значение a: ");
				argA = int.Parse(Console.ReadLine());
					
				Console.WriteLine("Введите значение b: ");
				argB = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите значение c: ");
				argC = int.Parse(Console.ReadLine());
					
				break;
			}


			catch (Exception ex)
			{
				Console.WriteLine("Введено некорректное значение \n" + ex);
			}
		}
	}
}