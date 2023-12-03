

int[] rolCol = Console.ReadLine().
    Split()
    .Select(int.Parse)
    .ToArray();

int rows = rolCol[0];
int cols = rolCol[1];

char[,] matrix = new char[rows, cols];

int myRow = 0;
int myCol = 0;
int people = 0;


for (int row = 0; row < rows; row++)
{
    char[] chars= Console.ReadLine()
        .Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(char.Parse)
        .ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = chars[col];
        if (chars[col]=='B')
        {
            myCol = col;
            myRow = row;
        }
        else if (chars[col]=='P')
        {
            people++;
        }
    }
}

int move = 0;
int opTouch=0;

string comand;
while ((comand=Console.ReadLine())!="Finish")
{
    
    move++;

    switch (comand)
    {
        case "up":
            myRow--;
            if (myRow <0)
            {
                myRow = 0;
                move--;
                continue;
            }
            if (matrix[myRow,myCol]=='O')
            {
                myRow++;
                move--;
                continue;
            }
            else if (matrix[myRow, myCol] == 'P')
            {
                people--;
                opTouch++;
            }
            
            break;

        case "down":
            myRow++;
            if (myRow == rows)
            {
                myRow = rows - 1;
                move--;
                continue;
            }
            if (matrix[myRow, myCol] == 'O')
            {
                myRow--;
                move--;
                continue;
            }
            else if (matrix[myRow, myCol] == 'P')
            {
                people--;
                opTouch++;
            }
            

            break;

        case "left":
            myCol--;
            if (myCol < 0)
            {
                myCol=0;
                move--;
                continue;
            }
            if (matrix[myRow, myCol] == 'O')
            {
                myCol++;
                move--;
                continue;
            }
            else if (matrix[myRow, myCol] == 'P')
            {
                people--;
                opTouch++;
            }
            
            break;

        case "right":
            myCol++;

            if (myCol == cols)
            {   
                myCol=cols-1;
                move--;
                continue;
            }
            if (matrix[myRow, myCol] == 'O')
            {
                myCol--;
                move--;
                continue;
            }
            else if (matrix[myRow, myCol] == 'P')
            {
                people--;
                opTouch++;
            }
            
            break;
    }
    matrix[myRow, myCol] = '-';
    if (people == 0)
    {
        break;
    }
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {opTouch} Moves made: {move}");

