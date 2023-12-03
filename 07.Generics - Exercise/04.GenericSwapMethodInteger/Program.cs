
using GenericSwapMethodInteger;

Box<int> box = new Box<int>();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    int item = int .Parse(Console.ReadLine());
    box.Add(item);

}


int[] index = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
box.Swab(index[0], index[1]);
Console.WriteLine(box.ToString());
