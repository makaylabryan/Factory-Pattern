﻿namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels would you like your vehicle to have?");
            string numberOfWheels = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            vehicle.Drive();
            Console.ReadLine();
        }
    }
}
