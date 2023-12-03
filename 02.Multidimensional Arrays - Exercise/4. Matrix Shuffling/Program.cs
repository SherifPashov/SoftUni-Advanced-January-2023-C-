

int[] infoMatrix = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rows = infoMatrix[0];
int cols = infoMatrix[1];

int[,] matrix = new int[rows, cols];

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
string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] comand = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();
    if (comand[0]== "swap" && comand.Length == 5)
    {
        int row1 = int.Parse(comand[1]);
        int col1 = int.Parse(comand[2]);

        int row2 = int.Parse(comand[3]);
        int col2 = int.Parse(comand[4]);

        if (row1>=0 && row1<rows &&
            col1>=0  && col1<cols &&
            row2>=0 && row2 < rows &&
            col2>= 0 && col2<cols)
        {
            int element1 = matrix[row1, col1];

            matrix[row1, col1] = matrix[row2,col2];
            matrix[row2, col2] = element1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}