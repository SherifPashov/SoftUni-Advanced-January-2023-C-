

int numberComand = int.Parse(Console.ReadLine());


Stack<int> stack = new Stack<int>();

for (int i = 0; i < numberComand; i++)
{
    int[] info = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
    int comand = info[0];
    if (comand == 1)
    {
        int element = info[1];
        stack.Push(element);
    }
    else if (comand == 2)
    {
        stack.Pop();
    }
    else if (comand == 3)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());

        }
    }
    else if (comand == 4)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
    }

    
}
Console.WriteLine(String.Join(", ",stack ));