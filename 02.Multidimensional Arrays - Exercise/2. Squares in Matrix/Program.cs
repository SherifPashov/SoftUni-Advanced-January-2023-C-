
int[] mat = Console.ReadLine()
	.Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse)
	.ToArray();

int rows = mat[0];
int cols = mat[1];
char[,] matrx = new char[rows, cols];

int twoXTwo =0;
for (int row = 0; row < rows; row++)
{
	char[] chars = Console.ReadLine()
		.Split(" ", StringSplitOptions.RemoveEmptyEntries)
		.Select(char.Parse)
		.ToArray();

	for (int col = 0; col < cols; col++)
	{
		matrx[row, col] = chars[col];
	}
}

for (int row = 0; row < rows-1; row++)
{

	for (int col = 0; col < cols-1; col++)
	{
		if (matrx[row, col] == matrx[row+1,col]&&
			matrx[row,col] == matrx[row+1,col+1]&&
			matrx[row,col] == matrx[row, col+1])
		{
			twoXTwo++;
		}
	}
}
Console.WriteLine(twoXTwo);
