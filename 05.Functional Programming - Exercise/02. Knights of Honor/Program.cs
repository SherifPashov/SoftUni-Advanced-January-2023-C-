

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Action < string[] > print = names =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"Sir {name}");
    }
};

print(names);