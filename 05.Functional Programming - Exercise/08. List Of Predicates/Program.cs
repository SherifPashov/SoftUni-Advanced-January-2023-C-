int end = int.Parse(Console.ReadLine());

Func<int,List<int>> creatList = end =>
{
    List<int> list = new List<int>();
    for (int i = 1; i <= end; i++)
    {
        list.Add(i);
    }
    return list;
};

Func<List<int>, int[], List<int>> checking = (numbers, dels) =>
{
    List<int> list = new List<int>();
    foreach (var num in numbers)
    {
        bool mabe = true;
        foreach (var del in dels)
        {
            if (!(num % del == 0))
            {
                mabe = false;
            }
           
        }
        if (mabe)
        {
            list.Add(num);
        }
    }
    return list;
};


List<int> numbers = creatList(end);

int[] dels = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

List<int> list = checking(numbers, dels);
Console.WriteLine(String.Join(" ",list));
