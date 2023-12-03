

using _03.Stack;

CustomStack<int> stack = new();

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    string[] tokens = command
        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];

    if (action == "Push")
    {
        int[] itemsToPush = tokens
            .Skip(1)
            .Select(int.Parse)
            .ToArray();

        foreach (var item in itemsToPush)
        {
            stack.Push(item);
        }
    }
    else if (action == "Pop")
    {
        stack.Pop();
        
        
    }
}

stack.Print();