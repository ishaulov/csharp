namespace homeworks;

public static class StackExtension
{
    public static Stack Merge(this Stack stack1, Stack stack2)
    {
        for (int i = 0; i < stack2.Size; i++)
        {
            stack1.Add(stack2.Top);
            stack2.Pop();
        }
        stack1.Add(stack2.Top);
        return stack1;
    }
}