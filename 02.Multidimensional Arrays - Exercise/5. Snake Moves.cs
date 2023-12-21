

int[] infoStairs = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
char[] snake = Console.ReadLine()
    .ToArray();

int rows = infoStairs[0];
int cols = infoStairs[1];
int count =0;

char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    if (row%2==0)
    {
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = snake[count];
            count++;
            if (count == snake.Length)
            {
                count = 0;
            }
        }
    }
    else
    {
     
        for (int col = cols - 1; col >= 0; col--)
        {
            matrix[row, col] = snake[count];
            count++;
            if (count == snake.Length)
            {
                count = 0;
            }
        }
    }
    
}
for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write(matrix[row,col]);
    }
    Console.WriteLine();
}