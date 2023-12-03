

using _05GenericCountMethodString;

Box<string> box = new Box<string>();
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string item = Console.ReadLine();
    box.Add(item);
}
string compareTo = Console.ReadLine();
Console.WriteLine(box.Count(compareTo));