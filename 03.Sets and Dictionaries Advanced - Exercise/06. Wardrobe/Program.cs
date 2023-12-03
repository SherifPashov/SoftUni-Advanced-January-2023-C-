



int num = int.Parse(Console.ReadLine());


Dictionary<string, Dictionary<string,int>> wardrobe = new();

for (int i = 0; i < num; i++)
{
    string[] info = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string color = info[0];

    string[] clothing = info[2]
        .Split(",", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }

    for (int k = 0; k < clothing.Length; k++)
    {
        if (!wardrobe[color].ContainsKey(clothing[k]))
        {
            wardrobe[color].Add(clothing[k],0);
        }
        wardrobe[color][clothing[k]]++;
    }

}
string[] specialClothingInfo = Console.ReadLine()
    .Split()
    .ToArray();
string specialColor = specialClothingInfo[0];
string specialClothing=specialClothingInfo[1];

foreach (var (color,item) in wardrobe)
{
    Console.WriteLine($"{color} clothes: ");
    foreach (var (clothing,count) in item)
    {
        Console.Write($"* {clothing} - {count}");
        if (clothing == specialClothing && specialColor == color)
        {
            Console.WriteLine($" (found!)");
        }
        else
        {
            Console.WriteLine();
        }
    }
}