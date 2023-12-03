

int[] ints = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int[], int> custumMin = ints =>
{
    int min = int.MaxValue;

    foreach (var num in ints)
    {
        if (num < min)
        {
            min = num;
        }
    }
    return min;
};
Console.WriteLine(custumMin(ints));