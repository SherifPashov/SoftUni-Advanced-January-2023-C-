string[] strings = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
   .ToArray();

Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));

print(strings);