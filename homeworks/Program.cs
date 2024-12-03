namespace homeworks

{
	internal class Program
	{
		public static void Main(string[] args)
		{
			Quadcopter quadcopter = new Quadcopter();

			quadcopter.GetComponents("rotor1", "rotor2", "rotor3");

			quadcopter.PrintComponents();

			Console.WriteLine(quadcopter.GetRobotName());
			Console.WriteLine(quadcopter.GetRobotType());
			Console.WriteLine(quadcopter.GetInfo());

			quadcopter.Charge();
		}
	}
}