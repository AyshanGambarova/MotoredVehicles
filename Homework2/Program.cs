using System;

namespace Motoredvehicles
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Car car = new Car("E class","Mercedes",2021);


            car.MotorSize = 5.5;
            car.HorsePower = 255;
            car.PassangerCount = 4;
            car.Transmission = 9;
            car.FuelUsedPerKm = 5;
            car.FuelAmount = 1894;
            car.Color = "Black";
            car.ProductionYear = 2021;
            car.FuelAmount = 15;

            car.GetInfo();


            car.IsOn = false;
            bool IsTurnOn = car.TurnOn(true);

            if (IsTurnOn)
            {
                car.Go(676);
            }
            else
            {
                Console.WriteLine("Gede bilmez");
            }



           

            

            

            Boat boat = new Boat();
            boat.Make = "Yachts";
            boat.Model = "Majesty 100";
            boat.MotorSize = 6;
            boat.ProductionYear = 2018;
            boat.PassangerCount = 12;
            boat.Transmission = 15;

            Motorcycle mc = new Motorcycle();
            mc.Make = "Sport otorcycle";
            mc.Model = "Yamaha R3";
            mc.MotorSize = 125;
            mc.ProductionYear = 2019;
            mc.PassangerCount = 1;

           


                
            
        }
    }
}
