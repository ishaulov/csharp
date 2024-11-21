namespace homeworks;

public class Stack
{
	private List<string> _stack;
	public int Size { get; set; }
	
	public int Top { get; set; }
	
	public Stack(List<string> stack)
	{
		_stack = stack;
		/*foreach (var value in values)
		{
			if (value == null)
				throw new NullReferenceException("NUll value null");
			_stack.AddLast(value);
		}*/
	}

	public void Add(string item)
	{
		if (item == null)
			throw new NullReferenceException("NUll value null");
		_stack.Add(item);
	}

	public string Pop()
	{
		if (_stack.Count == 0)
		{
			throw new NullReferenceException("Stack is empty");
		}
		else
		{
			return _stack[_stack.Count - 1];
		}
		
	}
}