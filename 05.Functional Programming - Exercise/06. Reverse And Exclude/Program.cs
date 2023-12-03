List<int> numbers = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int del = int.Parse(Console.ReadLine());

Func<List<int>,Predicate<int> , List<int>> reverseAndDel = (numbers,match) =>
{
    List<int> list = new List<int>();

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        if (!match(numbers[i]))
        {
            list.Add(numbers[i]);
        }
        
    }
    return list;
};

numbers = reverseAndDel(numbers, n => n % del == 0);
Console.WriteLine(String.Join(" ",numbers));


