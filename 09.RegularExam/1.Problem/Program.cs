
int[] infoTextiles = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] infoMedicaments = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Queue<int> textiles = new();
Stack<int> medicaments = new();

Dictionary<string,int> nameCount = new Dictionary<string,int>();



for (int i = 0; i < infoTextiles.Length; i++)
{
    textiles.Enqueue(infoTextiles[i]);
}

for (int i = 0; i < infoMedicaments.Length; i++)
{
    medicaments.Push(infoMedicaments[i]);
}

while (textiles.Any() && medicaments.Any())
{
    int med = medicaments.Pop();
    int tex=textiles.Dequeue();

    if (med+tex == 30)
    {
        string patch = "Patch";
        if (!nameCount.ContainsKey(patch))
        {
            nameCount[patch] = 0;
        }
        nameCount[patch]++;
    }
    else if (med + tex ==40)
    {
        string bandage = "Bandage";
        if (!nameCount.ContainsKey(bandage))
        {
            nameCount[bandage] = 0;
        }
        nameCount[bandage]++;

    }
    else if (med + tex ==100)
    {
        string medKit = "MedKit";
        
        if (!nameCount.ContainsKey("MedKit"))
        {
            nameCount[medKit] = 0;
        }
        nameCount[medKit]++;

    }
    else if (med + tex > 100)
    {
        string medKit = "MedKit";
        if (!nameCount.ContainsKey(medKit))
        {
            nameCount[medKit] = 0;
        }
        nameCount[medKit]++;

        int sum =med+tex-100;
        int medcur = medicaments.Pop();
        medicaments.Push(medcur+sum);

    }
    else
    {
        medicaments.Push(med + 10);
    }
}
if ((textiles.Count==0&&medicaments.Count==0))
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}
else if (!textiles.Any())
{
    Console.WriteLine("Textiles are empty.");
}

nameCount = nameCount
    .OrderByDescending(x => x.Value)
    .ThenBy(x => x.Key)
    .ToDictionary(x => x.Key,x => x.Value);

foreach (var item in nameCount)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ",medicaments)}");
}
else if (textiles.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}