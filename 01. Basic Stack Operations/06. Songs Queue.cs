using System.Text;

string[] songs = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

Queue<string> queue = new Queue<string>();
for (int i = 0; i < songs.Length; i++)
{
    if (!queue.Contains(songs[i]))
    {
        queue.Enqueue(songs[i]);
    }
}

while (queue.Count > 0)
{
    string com = Console.ReadLine();
    string[] comand = com
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (comand[0] == "Play")
    {
        queue.Dequeue();
    }
    else if (comand[0] == "Add")
    {
        StringBuilder Addsongs = new(com);
        Addsongs.Replace("Add ", "");

        string stringSongs = Addsongs.ToString();
        if (queue.Contains(stringSongs))
        {
            Console.WriteLine($"{Addsongs} is already contained!");
            continue;
        }
        queue.Enqueue(stringSongs);

    }
    else if (comand[0] == "Show")
    {
        Console.WriteLine(string.Join(", ", queue));
    }
}
Console.WriteLine("No more songs!");