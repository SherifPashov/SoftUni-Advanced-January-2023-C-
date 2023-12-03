using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Engine
    {
        private int speed;
        private int pawer;

        public Engine(int speed, int pawer)
        {
            Speed = speed;
            Pawer = pawer;
        }
        public int Speed { get; set; }
        public int Pawer { get; set; }
    }
}
