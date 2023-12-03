int spetionNumber = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string, int, bool> check = (name, number) =>
{
    int sumChar = 0;
    foreach (var charName in name)
    {
        sumChar += (int)charName;
    }
    if (sumChar>= number)
    {
        return true;
    }
    return false;
};

foreach (var name in names)
{
    if (check(name,spetionNumber))
    {
        Console.WriteLine(name);
        return;
    }
}