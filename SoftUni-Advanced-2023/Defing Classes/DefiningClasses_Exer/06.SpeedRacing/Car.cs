using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SpeedRacing
{
    public class Cars
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance = 0;
       


        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }


        public double FuelConsumptionPerKilometerrty
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Cars(string model, double fuelAm, double fuleConsPer1Km)
        {
            this.Model = model;
            this.FuelAmount = fuelAm;
            this.FuelConsumptionPerKilometerrty = fuleConsPer1Km;
                       
        }

        public void MovingCar(string model, double drivingDistance)
        {

            double fuelConsumed = drivingDistance * fuelConsumptionPerKilometer;

            if (this.fuelAmount - fuelConsumed < 0)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                
                this.TravelledDistance += drivingDistance;
                this.FuelAmount -= fuelConsumed;
            }
        }

        
    }
}
