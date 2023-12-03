using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Car
    {
        private string model;
        private Engine energy;
        private Cargo cargo;
        private Tire tire;



        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tire { get; set; }  

        public Car (string model,
        int speed,
        int power,
        int weight,
        string type,
        double tyre1pressure,
        int tyre1age,
        double tyre2pressure,
        int tyre2age,
        double tyre3pressure,
        int tyre3age,
        double tyre4pressure,
        int tyre4age
            )
        {
            this.Model = model;
            Engine = new(speed, power);
            Cargo = new(weight, type);
            Tire = new Tire[4];
            Tire[0] = new(tyre1age, tyre1pressure);
            Tire[1] = new(tyre2age, tyre2pressure);
            Tire[2] = new(tyre3age, tyre3pressure);
            Tire[3] = new(tyre4age, tyre4pressure);



        }
    }
}
