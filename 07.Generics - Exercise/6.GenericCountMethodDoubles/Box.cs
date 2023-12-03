using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in items)
            {
                sb.Append($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public List<T> Swap(int first, int second)
        {
            if (first >= 0 && first < items.Count)
            {
                if (second >= 0 && second < items.Count)
                {
                    T itemFirst = items[first];
                    items[first] = items[second];
                    items[second] = itemFirst;

                }
            }
            return items;
        }

        public int Count(T itemToCompare)
        {
            int count = 0;

            foreach (var item in items)
            {
                if (item.CompareTo(itemToCompare)
                    > 0)
                {
                    count++;
                }
            }

            return count;

        }
    }
}
