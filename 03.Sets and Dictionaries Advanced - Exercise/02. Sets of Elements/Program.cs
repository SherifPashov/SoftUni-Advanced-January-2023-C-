

int[] number = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

HashSet<int> first = new();
HashSet<int> second = new();
for (int i = 0; i < number[0]; i++)
{
    int num = int.Parse(Console.ReadLine());
    first.Add(num);
}
for (int i = 0; i < number[1]; i++)
{
    int num = int.Parse(Console.ReadLine());
    second.Add(num);
}

Console.WriteLine(String.Join(" ", first.Intersect(second)));