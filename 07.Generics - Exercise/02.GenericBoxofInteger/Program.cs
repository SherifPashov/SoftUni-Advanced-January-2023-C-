


using BoxOfString;

Box<int> box = new Box<int>();

int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    int item = int.Parse(Console.ReadLine());
    box.Add(item);
}

Console.WriteLine(box.ToString());