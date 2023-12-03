using System;

int size = int.Parse(Console.ReadLine());

char[,] battle = new char[size, size];

int naviCol = 0;
int naviRow = 0;

for (int row = 0; row < size; row++)
{
	string chars = Console.ReadLine();
		
	for (int col = 0; col < size; col++)
	{
		battle[row, col] = chars[col];

		if (chars[col]=='S')
		{
			naviCol = col;
			naviRow = row;
		}
	}
}
int c = 0;
int healt = 3;

battle[naviRow, naviCol] = '-';
while (true)
{
	string comand = Console.ReadLine();

	switch (comand)
	{
		case "up":
			naviRow--;

			break;

        case "down":
			naviRow++;
            break;

        case "left":
			naviCol--;
            break;

        case "right":
			naviCol++;
            break;
    }
	if (battle[naviRow,naviCol]=='C')
	{
		c++;
	}
	else if (battle[naviRow,naviCol]=='*')
	{
		healt--;
	}

	if (healt==0)
	{
		Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{naviRow}, {naviCol}]!");
		break;
	}

	if (c==3)
	{
		Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
		break ;

	}
	battle[naviRow, naviCol] = '-';
}

battle[naviRow, naviCol] = 'S';
for (int row = 0; row < size; row++)
{
	for (int col = 0; col < size; col++)
	{
		Console.Write(battle[row,col]);
	}
	Console.WriteLine();
}