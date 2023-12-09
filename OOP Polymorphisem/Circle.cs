using OOP_Polymorphisem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Circle : Geomertri
    {
        public double _Radius { get; set; }

        public Circle(double Radius) 
        {
            this._Radius = Radius;
        }

        // Override the GetArea method to provide a specific implementation for circle
        public override float GetArea()
        {
            // Calculate the area of the circle using the formula: π * r^2

            Console.Write($"Area Cirkel: ");
            return (float)(Math.PI * (Math.Pow(_Radius, 2)));
        }
    }
}
