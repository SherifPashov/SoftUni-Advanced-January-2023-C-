

int num = int.Parse(Console.ReadLine());
Dictionary<int, int> evenTimes = new();

for (int n = 0; n < num; n++)
{
    int number = int.Parse(Console.ReadLine());

	if (!evenTimes.ContainsKey(number))
	{
		evenTimes[number] = 0;
	}
	evenTimes[number]++;
}

foreach (var (key,value) in evenTimes)
{
	if (value%2==0)
	{
		Console.WriteLine(key);
	}
}