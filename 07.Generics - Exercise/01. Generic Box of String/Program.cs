

using BoxOfString;

Box<string> box = new Box<string>();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string item = Console.ReadLine();
    box.Add(item);
}

Console.WriteLine(box.ToString());