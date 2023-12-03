using _3.GenericSwapMethodStrings;

Box<string> box = new Box<string>();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string input = Console.ReadLine();
    box.Add(input);
}
int[] inputIndex = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
box.Swap(inputIndex[0],inputIndex[1]);
Console.WriteLine(box.ToString());