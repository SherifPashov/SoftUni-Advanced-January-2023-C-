

using DefiningClasses;

int number = int.Parse(Console.ReadLine());
List<Person> peoples = new List<Person>();

for (int i = 0; i < number; i++)
{
    string[] input = Console.ReadLine()
        .Split();
    Person person = new Person(input[0], int.Parse(input[1]));
   peoples.Add(person);
}
foreach (var people in peoples.OrderBy(p => p.Name))
{
    if (people.Age>30)
    {
        Console.WriteLine($"{people.Name} - {people.Age}");
    }
   
}
