using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Threeuple
{
    internal class Threeuple<T1,T2,T3>
    {
        public Threeuple(T1 first, T2 second, T3 third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public override string ToString()
        {
            return $"{First} -> {Second} -> {Third}";
        }

        public T1 First { get; set; }
        public T2 Second { get; set; }

        public T3 Third { get; set; }
    }
}
