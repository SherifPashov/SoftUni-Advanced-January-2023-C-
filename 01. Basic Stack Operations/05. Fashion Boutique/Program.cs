

int[] clothes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rackCapacity = int.Parse(Console.ReadLine());
int nowRack = 0;
int countRack = 0;

Stack<int> stack = new();

for (int i = 0; i < clothes.Length; i++)
{
    stack.Push(clothes[i]);
}

while (stack.Count > 0)
{
    if (stack.Peek() > nowRack)
    {
        
        nowRack = rackCapacity;
        countRack++;
    }
    else
    {
        nowRack -= stack.Pop();
    }
}
Console.WriteLine(countRack);