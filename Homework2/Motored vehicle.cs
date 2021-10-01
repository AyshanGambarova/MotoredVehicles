using System;
using System.Collections.Generic;
using System.Text;

namespace Motoredvehicles
{
    class Motoredvehicle
    {
        public Motoredvehicle()
        {

        }

        public Motoredvehicle( string Model,string Make,int Year)
        {
           this.Model = Model;
           this.Make = Make;
           this.ProductionYear = Year;

        }

        public void GetInfo()
        {
            Console.WriteLine($"{Model} {Make} {Color} {ProductionYear}  {PassangerCount} "); 
        }

        public virtual string GetDetailedInfo()
        {
            return $"{MotorSize} {FuelTankSize} {FuelUsedPerKm} {Transmission} {HorsePower}";
        }




        public string Model;
        public string Make;
        public int ProductionYear;
        public double MotorSize;
        public int FuelTankSize;
        public int FuelAmount;
        public int FuelUsedPerKm;
        public string Color;
        public int Transmission;
        public int HorsePower;
        public int PassangerCount;



    }
}
