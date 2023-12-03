


Func<List<string>, string, string, List<string>> checkingDouble = (peoples, filter, value) =>
{
    List<string> list = new List<string>();
    if (filter == "StartsWith"|| filter == "EndsWith" || filter == "Length")
    {
        foreach (var people in peoples)
        {
            switch (filter)
            {
                case "StartsWith":
                    if (people.StartsWith(value))
                    {
                        list.Add(people);
                        list.Add(people);
                    }
                    else
                    {
                        list.Add(people);
                    }
                    break;
                case "EndsWith":
                    if (people.EndsWith(value))
                    {
                        list.Add(people);
                        list.Add(people);
                    }
                    else
                    {
                        list.Add(people);
                    }
                    break;
                case "Length":
                    if (people.Length == int.Parse(value))
                    {
                        list.Add(people);
                        list.Add(people);
                    }
                    else
                    {
                        list.Add(people);
                    }
                    break;
                
            }

        }
             return list;
    
    }
    return peoples;
};


Func<List<string>, string, string, List<string>> checkingRemove = (peoples, filter, value) =>
{
    List<string> list = peoples;

    for (int i = 0; i < list.Count; i++)
    {
        switch (filter)
        {
            case "StartsWith":
                if (list[i].StartsWith(value))
                {
                    list.Remove(list[i]);
                    i--;
                }
                break;
            case "EndsWith":
                if (list[i].EndsWith(value))
                {
                    list.Remove(list[i]);
                    i--;
                }
                break;
            case "Length":
                if (list[i].Length == int.Parse(value))
                {
                    list.Remove(list[i]);
                    i--;
                }
                break;
        }
    }
       


    
    return list;
};


List<string> peoples = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string comands = Console.ReadLine();



while (comands != "Party!")
{
    string[] info = comands
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string comand = info[0];
    string filter = info[1];
    string value = info[2];

    if (comand == "Double")
    {
        peoples= checkingDouble(peoples,filter,value);
    }
    else if (comand == "Remove")
    {
        peoples = checkingRemove(peoples,filter,value);
    }


    comands = Console.ReadLine();
}


if (peoples.Count>0)
{
    
    Console.WriteLine($"{string.Join(", ",peoples)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}


