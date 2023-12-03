
using GenericCountMethodDoubles;

Box<double> box =new Box<double>();

int numb = int.Parse(Console.ReadLine());

for (int i = 0; i < numb; i++)
{
    double item = double.Parse(Console.ReadLine());
    box.Add(item);
}
double compareTo = double.Parse(Console.ReadLine());
Console.WriteLine(box.Count(compareTo));