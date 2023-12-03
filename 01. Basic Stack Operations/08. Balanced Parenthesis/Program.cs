

string peranthess = Console.ReadLine();

Stack<char> open = new Stack<char>();
Stack<char> close = new Stack<char>();

foreach (var item in peranthess)
{
	if (item == '('|| item == '{' || item == '[')
	{
		open.Push(item);
	}
	if (item == ')' || item == '}' || item == ']')
	{
		close.Push(item);
        if (open.Count == 0 || close.Count == 0)
        {
            continue;
        }

		char op = open.Peek();
		char cl = close.Peek();

		if (op =='(' )
		{
			if (cl == ')')
			{
                open.Pop();
                close.Pop();
            }
		}
        else if (op == '{')
        {
            if (cl == '}')
            {
                open.Pop();
                close.Pop();
            }
        }
        else if (op == '[')
        {
            if (cl == ']')
            {
                open.Pop();
                close.Pop();
            }
        }
	}
}
if (open.Count>0 || close.Count>0)
{
	Console.WriteLine("NO");
}
else
{
	Console.WriteLine("YES");
}