

Dictionary<string, List<string>> comandFilter = new();

List<string> peoples = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string input = Console.ReadLine();

while (!(input == "Print"))
{
    string[] comandInfo = input.Split(";").ToArray();

    string comand = comandInfo[0];
    string filterType = comandInfo[1];
    string filterParameter = comandInfo[2];

    if (comand == "Add filter")
    {
        switch (filterType)
        {

            case "Starts with":
                if (!comandFilter.ContainsKey(filterType))
                {
                    comandFilter[filterType] = new List<string>();
                }

                comandFilter[filterType].Add(filterParameter);

                break;

            case "Ends with":

                if (!comandFilter.ContainsKey(filterType))
                {
                    comandFilter[filterType] = new List<string>();
                }

                comandFilter[filterType].Add(filterParameter);

                break;

            case "Length":

                if (!comandFilter.ContainsKey(filterType))
                {
                    comandFilter[filterType] = new List<string>();
                }

                comandFilter[filterType].Add(filterParameter);

                break;

            case "Contains":

                if (!comandFilter.ContainsKey(filterType))
                {
                    comandFilter[filterType] = new List<string>();
                }

                comandFilter[filterType].Add(filterParameter);

                break;
        }
    }
    else if (comand == "Remove filter")
    {

        switch (filterType)
        {
            case "Starts with":
                if (!comandFilter.ContainsKey(filterType))
                {
                    break;
                }
                if (comandFilter[filterType].Contains(filterParameter))
                {
                    comandFilter[filterType].Remove(filterParameter);
                }

                break;

            case "Ends with":

                if (!comandFilter.ContainsKey(filterType))
                {
                    break;
                }
                if (comandFilter[filterType].Contains(filterParameter))
                {
                    comandFilter[filterType].Remove(filterParameter);
                }

                break;

            case "Length":

                if (!comandFilter.ContainsKey(filterType))
                {
                    break;
                }
                if (comandFilter[filterType].Contains(filterParameter))
                {
                    comandFilter[filterType].Remove(filterParameter);
                }

                break;

            case "Contains":

                if (!comandFilter.ContainsKey(filterType))
                {
                    break;
                }
                if (comandFilter[filterType].Contains(filterParameter))
                {
                    comandFilter[filterType].Remove(filterParameter);
                }

                break;
        }
    }




    input = Console.ReadLine();
}


foreach (var (filteType, filterParameter) in comandFilter)
{
    switch (filteType)
    {
        case "Starts with":
            for (int i = 0; i < filterParameter.Count; i++)
            {
                for (int m = 0; m < peoples.Count; m++)
                {
                    if (peoples[m].StartsWith(char.Parse(filterParameter[i])))
                    {
                        peoples.Remove(peoples[m]);
                    }
                }
            }
            break;
        case "Ends with":
            for (int i = 0; i < filterParameter.Count; i++)
            {
                for (int m = 0; m < peoples.Count; m++)
                {
                    if (peoples[m].EndsWith(char.Parse(filterParameter[i])))
                    {
                        peoples.Remove(peoples[m]);
                    }
                }
            }
            break;
        case "Length":
            for (int i = 0; i < filterParameter.Count; i++)
            {
                for (int m = 0; m < peoples.Count; m++)
                {
                    if (peoples[m].Length == int.Parse(filterParameter[i])) ;
                    {
                        peoples.Remove(peoples[m]);
                    }
                }
            }
            break;
        case "Contains":
            for (int i = 0; i < filterParameter.Count; i++)
            {
                for (int m = 0; m < peoples.Count; m++)
                {
                    if (peoples[m].Contains(filterParameter[i]))
                    {
                        peoples.Remove(peoples[m]);
                    }
                }
            }
            break;

    }
}
Console.WriteLine(string.Join(" ", peoples));
