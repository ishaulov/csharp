using System.Collections;
using System.Diagnostics;

namespace myfirstapp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// listExample();
			
			// arrayList();

			LinkedList();
		}

		public static void listExample()
		{
			var rand = new Random();
			var list = new List<int>();
			
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			for (int i = 0; i < 1000000; i++)
			{
				list.Add(rand.Next(1, 100000));
			}

			stopwatch.Stop();
			Console.WriteLine($"Time for generate list of elements: {stopwatch.ElapsedMilliseconds} ms");
			
			var stopwatch1 = new Stopwatch();
			stopwatch1.Start();
			Console.WriteLine(list[496753]);
			stopwatch1.Stop();
			Console.WriteLine($"Time for found element 496753: {stopwatch1.ElapsedMilliseconds} ms");

			var stopwatch2 = new Stopwatch();
			stopwatch2.Start();
			foreach (int value in list)
			{
				if (value % 777 == 0)
					Console.WriteLine($"Value is: {value}");
			}
			stopwatch2.Stop();
			Console.WriteLine($"Time for /777: {stopwatch2.ElapsedMilliseconds} ms");
		}

		public static void arrayList()
		{
			var rand = new Random();
			var arrList = new ArrayList();
			
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			for (int i = 0; i < 1000000; i++)
			{
				arrList.Add(rand.Next(1, 100000));
			}

			stopwatch.Stop();
			Console.WriteLine($"Time for generate arraylist of elements: {stopwatch.ElapsedMilliseconds} ms");
			
			var stopwatch1 = new Stopwatch();
			stopwatch1.Start();
			Console.WriteLine(arrList[496753]);
			stopwatch1.Stop();
			Console.WriteLine($"Time for found element 496753 of arraylist: {stopwatch1.ElapsedMilliseconds} ms");

			var stopwatch2 = new Stopwatch();
			stopwatch2.Start();
			foreach (int value in arrList)
			{
				if (value % 777 == 0)
					Console.WriteLine($"Value is: {value}");
			}
			stopwatch2.Stop();
			Console.WriteLine($"Time for /777 of arraylist: {stopwatch2.ElapsedMilliseconds} ms");		
		}
		
		public static void LinkedList()
		{
			var rand = new Random();
			var linkedList = new LinkedList<int>();
			
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			for (int i = 0; i < 1000000; i++)
			{
				linkedList.AddLast(rand.Next(1, 100000));
			}

			stopwatch.Stop();
			Console.WriteLine($"Time for generate linkedList of elements: {stopwatch.ElapsedMilliseconds} ms");
			
			var stopwatch1 = new Stopwatch();
			stopwatch1.Start();
			Console.WriteLine(linkedList.ElementAt(496753));
			stopwatch1.Stop();
			Console.WriteLine($"Time for found element 496753 of linkedList: {stopwatch1.ElapsedMilliseconds} ms");

			var stopwatch2 = new Stopwatch();
			stopwatch2.Start();
			foreach (int value in linkedList)
			{
				if (value % 777 == 0)
					Console.WriteLine($"Value is: {value}");
			}
			stopwatch2.Stop();
			Console.WriteLine($"Time for /777 of arraylist: {stopwatch2.ElapsedMilliseconds} ms");		
		}
	}
}