using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.SOLID.L
{
    public class Square : Shape
    {
        private double sideLength;
        public double SideLength
        {
            get => sideLength;
            set => sideLength = value;
        }

        public override double Area => sideLength *sideLength;
    }
    /*
        Shape rectangle = new Rectangle { Width = 5, Height = 4 };

        Console.WriteLine($"Area of the rectangle: {rectangle.Area}");

        Shape square = new Square { SideLength = 5 };

        Console.WriteLine($"Area of the square: {square.Area}");
     */

   

}
