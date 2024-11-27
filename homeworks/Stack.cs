namespace homeworks;

public class Stack
{
	private List<string> _stack;

	public int Size
	{
		get { return _stack.Count; }
	}

	public string Top
	{
		get { return _stack[_stack.Count - 1]; }
	}

	public Stack(params string[] elements)
	{
		_stack = new List<string>(elements);
	}

	public void Add(string item)
	{
		if (item == null)
			throw new NullReferenceException("Null value is not allowed.");
		_stack.Add(item);
	}

	public void Pop()
	{
		if (_stack.Count == 0)
		{
			throw new NullReferenceException("Stack is empty!");
		}
		else
		{
			_stack.RemoveAt(_stack.Count - 1);
		}
	}

	public void StackPrint()
	{
		for (int i = 0; i < _stack.Count; ++i)
		{
			Console.Write(_stack[i] + " ");
		}

		Console.WriteLine();
	}
}