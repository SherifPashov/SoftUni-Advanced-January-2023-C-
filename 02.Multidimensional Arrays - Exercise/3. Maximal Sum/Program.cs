

using System.Net.Sockets;

int[] info = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = info[0];
int cols = info[1];

int[,] matrix = new int[rows, cols];

int sumMax = int.MinValue;
int[,] max = new int[3, 3];

for (int row = 0; row < rows; row++)
{
    int[] infoRow = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = infoRow[col];
    }
}

for (int row = 0; row < rows-2; row++)
{

    for (int col = 0; col < cols-2; col++)
    {
        int sum = matrix[row, col] + 
            matrix[row+1,col] +
            matrix[row+2,col] +

            matrix[row, col+1] +
            matrix[row+1, col+1] +
            matrix[row+2, col+1] +

            matrix[row, col+2] +
            matrix[row+1, col+2] +
            matrix[row+2, col+2] ;
        if (sumMax<sum)
        {
            sumMax = sum;
            for (int maxRow = 0; maxRow < 3; maxRow++)
            {
                for (int maxCol = 0; maxCol < 3; maxCol++)
                {
                    max[maxRow,maxCol]=matrix[row+maxRow,col+maxCol];
                }
            }
        }
    }
}

Console.WriteLine($"Sum = {sumMax}");
for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.Write(max[row,col] + " ");
    }
    Console.WriteLine();
}