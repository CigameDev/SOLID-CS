using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.OopPrinciples.Polymorphism
{
    public class Plane : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Plane is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Plane is stopping.");
        }
    }
}
