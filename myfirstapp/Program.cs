namespace myfirstapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new[] { 1, 2, 3 };
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

            Console.ReadLine();
        }
    }
}