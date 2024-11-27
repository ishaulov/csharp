namespace homeworks

{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Stack stack = new Stack("a", "b", "c");

			Stack merge = stack.Merge(new Stack("1", "2", "3"));
			merge.StackPrint();

			Console.WriteLine($"Count of stack elements: " + stack.Size);
			Console.WriteLine($"Last element of stack: " + stack.Top);
		}
	}
}