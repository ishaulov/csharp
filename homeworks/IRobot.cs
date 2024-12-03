namespace homeworks;

public interface IRobot
{
	public string GetInfo();

	public List<string> GetComponents(params string[] components);

	public string GetRobotType()
	{
		return "I am a simple robot.";
	}
}