

using _7.Tuple;

string[] nameAdress = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] nameLiters = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] intDouble = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

CustumTuple<string, string> tupleNameAdres = 
    new($"{nameAdress[0]} {nameAdress[1]}", nameAdress[2]);

CustumTuple<string, int> tupleNameLiters =
    new(nameLiters[0], int.Parse(nameLiters[1]));

CustumTuple<int, double> tupleIntDouble =
    new(int.Parse(intDouble[0]), double.Parse(intDouble[1]));

Console.WriteLine(tupleNameAdres);
Console.WriteLine(tupleNameLiters);
Console.WriteLine(tupleIntDouble);

