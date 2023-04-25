using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class UnknownVehicle : IVehicle
    {
        public UnknownVehicle() 
        { 
        }
        public void Drive()
        {
            Console.WriteLine($"Here is your unidentified driving object");
        }
    }
}
