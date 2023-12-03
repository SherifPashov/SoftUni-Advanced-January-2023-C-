using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> items;

        public CustomStack()
        {
            items = new List<T>();
        }

        

        public T Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No elements");
                return default;
            }
            else
            {
                T item = items[items.Count-1];
                items.RemoveAt(items.Count-1);
                return item;
            }
            
        }
        public void Push(T item)
        {
            items.Add(item);
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        public void Print()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
            for (int i = items.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }

        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
