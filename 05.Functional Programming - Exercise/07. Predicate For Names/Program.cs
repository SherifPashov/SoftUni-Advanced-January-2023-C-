int lenght = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Action<int, string[]> print = (lenght, names) =>
{
    foreach (var name in names)
    {
        if (name.Length <= lenght)
        {
            Console.WriteLine(name);
        }
    }
};
print(lenght, names);
