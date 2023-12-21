
int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
	int[] ifo = Console.ReadLine()
		.Split(" ", StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse)
		.ToArray();

	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = ifo[col];
	}
}

int sumFirstDiagonal = 0;
for (int i = 0; i < size; i++)
{
	sumFirstDiagonal += matrix[i, i];
}

int sumSecondDiagonal = 0;

for (int i = 0; i < size; i++)
{
	sumSecondDiagonal+= matrix[size -1 - i , i];
}
Console.WriteLine(Math.Abs(sumFirstDiagonal - sumSecondDiagonal));
