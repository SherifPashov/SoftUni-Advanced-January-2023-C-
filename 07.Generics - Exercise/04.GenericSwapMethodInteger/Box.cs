using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodInteger
{
    public class Box <T>
    {
        private List<T> list;
        public Box()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public override string ToString()
        
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
       

        public List<T> Swab(int first, int second)
        {
            if (first>=0 && first< list.Count)
            {

                if (second>=0 && second<list.Count )
                {
                    T itemFirst = list[first];
                    list[first] = list[second];
                    list[second] = itemFirst;
                }
            }
            return list;
        }

    }
    
}
