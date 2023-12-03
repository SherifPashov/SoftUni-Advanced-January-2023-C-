


int count = int.Parse(Console.ReadLine());

int start = -1;

Stack<int> petrol = new();
Stack<int> distance = new();

for (int i = 0; i < count; i++)
{
    int[] infoPomp = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    int literPump = infoPomp[0];
    int rangeNextPump = infoPomp[1];


    if (petrol.Count<1)
    {
        petrol.Push(literPump);
        distance.Push(rangeNextPump);
        continue;
    }
    if (petrol.Peek()> rangeNextPump)
    {
        start = i-1;
        Console.WriteLine(start);
        return;
    }
    petrol.Push(literPump);
    distance.Push(rangeNextPump);

}


