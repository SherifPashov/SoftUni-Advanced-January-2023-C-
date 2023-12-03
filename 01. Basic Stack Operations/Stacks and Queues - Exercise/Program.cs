using System;

int[] info = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
int[] element = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int count = info[0];
int countPop = info[1];
int magicNumber = info[2];

Stack<int> numbers = new();

for (int i = 0; i < count; i++)
{
    numbers.Push(element[i]);
}

for (int i = 0; i < countPop; i++)
{
    int number = numbers.Pop();
    
}

if (numbers.Contains(magicNumber))
{
    Console.WriteLine("true");
}
else if (numbers.Count > 0)
{
    Console.WriteLine(numbers.Min());
}
else
{
    Console.WriteLine(0);
}
