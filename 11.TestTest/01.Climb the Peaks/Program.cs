


Dictionary<string, int> namePeaksAndDifficulty = new Dictionary<string, int>() 
{
    {"Vihren", 80},
    {"Kutelo", 90},
    {"Banski Suhodol", 100},
    {"Polezhan", 60},
    {"Kamenitza", 70},

};

Queue<string> namePeaks = new( new List<string>()
{ "Vihren",
"Kutelo",
"Banski Suhodol",
"Polezhan",
"Kamenitza"
});

List<string> complatePeaks = new();

Stack<int> foods = new Stack<int>
    (Console.ReadLine()
    .Split(", ")
    .Select(int.Parse));

Queue<int> stavinaS = new Queue<int>
    (Console.ReadLine()
    .Split(", ")
    .Select(int.Parse));

while (stavinaS.Any()&& foods.Any() && namePeaks.Any())
{
    int food = foods.Pop();
    int stavina = stavinaS.Dequeue();
    int peakDifficulty = namePeaksAndDifficulty[namePeaks.Peek()];

    if (food + stavina >= peakDifficulty)
    {
        complatePeaks.Add(namePeaks.Dequeue());
    }

}

if (namePeaks.Any())
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
else
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}

if (complatePeaks.Any())
{
    Console.WriteLine("Conquered peaks:");

    foreach (string peak in complatePeaks)
    {
        Console.WriteLine(peak);
    }
}