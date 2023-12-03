
using _8.Threeuple;

string[] nameAdresTown = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] nameLitersDrunk = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] nameBalanceBankName = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


Threeuple<string, string, string> tupleNameAdresTown =
    new($"{nameAdresTown[0]} {nameAdresTown[1]}", nameAdresTown[2], string.Join(" ",nameAdresTown[3..]));

Threeuple<string, int, bool> tupleNameLitersDrunk =
    new(nameLitersDrunk[0], int.Parse(nameLitersDrunk[1]), nameLitersDrunk[2]=="drunk");

Threeuple<string, double, string> tupleNameBalanceBankName =
    new(nameBalanceBankName[0], double.Parse(nameBalanceBankName[1]), nameBalanceBankName[2]);

Console.WriteLine(tupleNameAdresTown);
Console.WriteLine(tupleNameLitersDrunk);
Console.WriteLine(tupleNameBalanceBankName);