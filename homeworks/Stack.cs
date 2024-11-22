namespace homeworks;

public class Stack
{
	private List<string> _stack;

	public int Size
	{
		get
		{
			return _stack.Count;
		}
	}

	public string Top
	{
		get
		{
			return _stack[_stack.Count - 1];
		}
	}
	
	public Stack(List<string> stack)
	{
		_stack = stack;

	}

	public void Add(string item)
	{
		if (item == null)
			throw new NullReferenceException("NUll value null");
		_stack.Add(item);
	}

	public void Pop()
	{
		if (_stack.Count == 0)
		{
			throw new NullReferenceException("Stack is empty");
		}
		else
		{
			_stack.RemoveAt(_stack.Count - 1);
		}
	}
}