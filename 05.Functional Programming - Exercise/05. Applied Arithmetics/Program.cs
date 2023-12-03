

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string comand = Console.ReadLine();

Func< string,List<int>, List<int>> calcolate = (comand, numbers) =>
{
    List<int> result = new List<int>();

    foreach (var num in numbers)
    {
        switch (comand)
        {
            case "add":
                result.Add(num + 1);
                break;
            case "multiply":
                result.Add(num * 2);
                break;
            case "subtract":
                result.Add(num - 1);
                break;
                ;

        }
    }
    return result;
};

Action<List<int>> print = numbers => Console.WriteLine(String.Join(" ", numbers));

while (comand != "end")
{
    if (comand == "print")
    {
        print(numbers);
        comand = Console.ReadLine();
        continue;
    }
    numbers = calcolate(comand, numbers);
    comand = Console.ReadLine();
    
}