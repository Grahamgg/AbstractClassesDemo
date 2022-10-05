using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Prius";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
        

        


    }
}
