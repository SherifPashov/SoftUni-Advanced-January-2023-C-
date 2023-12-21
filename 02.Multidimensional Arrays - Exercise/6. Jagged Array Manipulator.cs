

int rows = int.Parse(Console.ReadLine());
int[][] matrix = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] element = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    matrix[row] = element;
}

for (int i = 0; i < rows-1; i++)
{
    if (matrix[i].Length == matrix[i+1].Length)
    {
        for (int m = 0; m < matrix[i].Length; m++)
        {
             matrix[i][m]*=2;
            matrix[i+1][m]*=2;
        }
    }
    else
    {
        for (int m = 0; m < matrix[i].Length; m++)
        {
            matrix[i][m] /= 2;
        }
        for (int k = 0; k < matrix[i+1].Length; k++)
        {
            matrix[i + 1][k] /= 2;
        }
    }
}
string info;
while ((info = Console.ReadLine())!="End")
{
    string[] comandInfo = info
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    int row = int.Parse(comandInfo[1]);
    int column = int.Parse(comandInfo[2]);
    int value = int.Parse(comandInfo[3]);

    string comand = comandInfo[0];
    if (comand == "Add")
    {
        

        if (row >= 0 && row < rows)
        {
            if (column >= 0 && column < matrix[row].Length)
            {
                matrix[row][column] += value;
            }
        }
    }
    else if (comand == "Subtract")
    {
        if (row >= 0 && row < rows)
        {
            if (column >= 0 && column < matrix[row].Length)
            {
                matrix[row][column] -= value;
            }
        }
    }
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write(matrix[row][col] + " ");
    }
    Console.WriteLine();
}