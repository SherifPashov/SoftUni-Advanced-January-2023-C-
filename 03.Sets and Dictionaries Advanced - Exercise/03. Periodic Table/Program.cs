
int num = int.Parse(Console.ReadLine());
SortedSet<string> specialElemnts = new SortedSet<string>();
for (int i = 0; i < num; i++)
{
    string[] elements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    foreach (var item in elements)
    {
        specialElemnts.Add(item);
    }
}
Console.WriteLine(string.Join(" ", specialElemnts));
