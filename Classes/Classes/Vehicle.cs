using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public enum VehicleType { Car, Truck, Van, Motorcycles, Spaceships, Planes, Boats }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }

        public VehicleType TypeOfVehicle { get; set; }

        public bool IsRunning { get; private set; }



        //below is constructor
        public Vehicle()    //to create a custom constructor, C# requires us to create a blank one first
        {

        }

        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle )
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = typeOfVehicle;
        }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("You turn off the vehicle.");
            IsRunning = false;
        }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void IndicateRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }
        public void IndicateLeft()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }

        public void TurnOnHazards() //in the real world, we consider hazards to simply be the right and left indicators flashing together
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOn();
        }

        public void TurnOffHazards()
        {
            RightIndicator.TurnOff();
            LeftIndicator.TurnOff();
        }


    }

    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void TurnOn()
        {
            IsFlashing = true;
        }

        public void TurnOff()
        {
            IsFlashing = false;
        }
    }
}
