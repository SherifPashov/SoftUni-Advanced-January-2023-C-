using System;
using System.Collections.Generic;
using System.Linq;

int[] info = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int start = info[0];
int end = info[1];




Func<int, int, List<int>> creatList = (start, end) => 
{
    List<int> list = new List<int>();

    for (int i = start; i <= end; i++)
    {
        list.Add(i);
    }
    return list;
};

List<int> numbers = creatList(start, end);

string oddOrEven = Console.ReadLine();

Predicate<int> mach;

if (oddOrEven == "even")
{
    mach = number => number % 2 == 0;
}
else
{
    mach=number => number % 2 != 0;
}

List<int> list = new List<int>();
foreach (var numbr in numbers)
{
    if (mach(numbr))
    {
       list.Add(numbr);        
    }
}
Console.WriteLine(String.Join(" ", list));