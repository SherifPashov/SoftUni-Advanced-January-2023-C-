﻿
using _01.ListyIterator;

List<string> items = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToList();
ListyIterator<string> listyIterator = new ListyIterator<string>(items);

string comand;

while ((comand=Console.ReadLine()) != "END")
{
    switch (comand)
    {
        case "Move":
            Console.WriteLine(listyIterator.Move());
            break;
        case "HasNext":
            Console.WriteLine(listyIterator.HasNext());
            break;
        case "Print":
            listyIterator.Print();
            break;
        
    }
}