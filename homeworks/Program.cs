namespace homeworks

{
	internal class Program
	{
		public static void Main(string[] args)
		{
			
			// this is test for MT
			List<string?> inputValues = new List<string?>();
			while (true)
			{
				string input = Console.ReadLine();
				if (input != "")
				{
					inputValues.Add(input);
				}
				else
				{
					Console.WriteLine("Result:");
					break;
				}
			}

			Stack stack = new Stack(inputValues);
			stack.Add("");
			// stack.Add("xx");
			// stack.Pop();
			
			Console.WriteLine($"Count of stack elements: " + stack.Size);
			Console.WriteLine($"Last element of stack: " + stack.Top);
		}
	}
}