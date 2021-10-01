using System;
using System.Collections.Generic;
using System.Text;

namespace Motoredvehicles
{
    class Car:Motoredvehicle
    {
        public Car(string model, string make, int year) : base(model, make, year)
        {

        }


        public bool IsOn;

        public bool TurnOn(bool turnon)
        {
            if (IsOn == turnon)
            {
                 return true;
            }
            return false;
        }

        public bool TurnOff(bool turnoff)
        {
            if (IsOn != turnoff)
            {
                return true;
            }
            return false;
        }




        public void Go(int distance)
        {
           
            if (FuelAmount>FuelUsedPerKm)
            {
                Console.WriteLine($"{distance} km mesafe qet edildi" );
            }
            else
            {
                Console.WriteLine("Kifayet qeder yanacaq yoxdur");
            }
        }

        public override string GetDetailedInfo()
        {
            return $"{base.GetDetailedInfo()} Fuel amount {FuelAmount}";
            
        }

        
    }
}
