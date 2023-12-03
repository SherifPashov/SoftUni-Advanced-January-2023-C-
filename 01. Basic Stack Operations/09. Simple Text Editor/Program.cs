

using System.Text;

int numberOperation = int.Parse(Console.ReadLine());

StringBuilder strings = new StringBuilder();
Stack<string> stack = new Stack<string>();
stack.Push("");

for (int i = 0; i < numberOperation; i++)
{
    string[] comand = Console.ReadLine()
        .Split()
        .ToArray();
    if (comand[0] == "1")
    {
        stack.Push(strings.ToString());
        strings.Append(comand[1]);
       
    }
    else if (comand[0] == "2")
    {
        int startIndex = strings.Length - int.Parse(comand[1]);

        if (startIndex>=0)
        {
            stack.Push(strings.ToString());
            strings.Remove(startIndex, int.Parse(comand[1]));
            
        }
        else
        {
            strings.Clear();
        }
       
    }
    else if (comand[0] == "3")
    {
        int index = int.Parse(comand[1]) - 1;
        if (index >= 0 && index < strings.Length)
        {
            Console.WriteLine(strings[index]);
        }
        
    }
    else if (comand[0] == "4")
    {
        strings.Clear();
        strings.Append(stack.Pop().ToString());
    }
}
