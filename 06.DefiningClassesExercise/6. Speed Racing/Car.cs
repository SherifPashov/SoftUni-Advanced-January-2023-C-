using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SpeedRacing
{
    internal class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        

        public string Model { get; 
            set; }
        public double FuelAmount { get; 
            set; }
        public double FuelConsumptionPerKilometer { get; 
            set; }
        public double TravelledDistance { get; 
            set; }

        public void Drive(double amountofKm)
        {
            if ((amountofKm * FuelConsumptionPerKilometer) > this.FuelAmount)
            {
                 Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount-=amountofKm * FuelConsumptionPerKilometer;
                TravelledDistance += amountofKm;
            }
        }
    }
}
