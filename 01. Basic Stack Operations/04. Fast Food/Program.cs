
int quantity = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new();

for (int i = 0; i < orders.Length; i++)
{
    queue.Enqueue(orders[i]);
}

int maxOrders = queue.Max();
Console.WriteLine(maxOrders);

foreach (int order in orders)
{
    if (quantity >= queue.Peek())
    {
       
        quantity-= queue.Peek();
        queue.Dequeue();
    }
    else 
    {
        
        Console.Write("Orders left: ");
        Console.WriteLine(String.Join(" ",queue));
        return;
    }
}

Console.WriteLine("Orders complete");