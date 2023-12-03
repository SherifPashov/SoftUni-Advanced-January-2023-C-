

int[] info = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int element = info[0];
int deQueues = info[1];
int magicNumber = info[2];
Queue<int> queue = new();

for (int i = 0; i < element; i++)
{
    queue.Enqueue(numbers[i]);
}

for (int i = 0; i < deQueues; i++)
{
    if (queue.Count>0)
    {
        queue.Dequeue();

    }
}

if (queue.Contains(magicNumber))
{
    Console.WriteLine("true");
}
else if (queue.Count > 0)
{
    Console.WriteLine(queue.Min());
    
}
else
{
    Console.WriteLine(0);
}