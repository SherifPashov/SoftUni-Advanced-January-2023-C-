using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stons;
        public Lake(List<int> stons)
        {
            this.stons = stons;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stons.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stons[i];
                }
            }

            for (int i = stons.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stons[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
