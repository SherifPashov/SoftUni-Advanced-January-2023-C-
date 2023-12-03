
char[] word = Console.ReadLine()
    .ToArray();

SortedDictionary<char, int> countSymbols = new();

foreach (var item in word)
{
    if (!countSymbols.ContainsKey(item))
    {
        countSymbols[item] = 0;
    }
    countSymbols[item]++;
}

foreach (var (key,value) in countSymbols)
{
    // : 1 time/s
    Console.WriteLine($"{key}: {value} time/s");
}

