

using _05.ComparingObjects;

List<Person> peoples = new();

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    string[] personInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Person person = new()
    {
        Name = personInfo[0],
        Age = int.Parse(personInfo[1]),
        Town = personInfo[2]
    };

    peoples.Add(person);
}

int compareIndex = int.Parse(Console.ReadLine()) - 1;

Person personToCompare = peoples[compareIndex];

int equalCount = 0;
int diffCount = 0;

foreach (var person in peoples)
{
    if (person.CompareTo(personToCompare) == 0)
    {
        equalCount++;
    }
    else
    {
        diffCount++;
    }
}

if (equalCount == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{equalCount} {diffCount} {peoples.Count}");
}