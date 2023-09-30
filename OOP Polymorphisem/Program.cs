using OOP_Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphisem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geomertri[] shapes = new Geomertri[5];
            {
                shapes[0] = new Circle(4);
                shapes[1] = new Rectangel(4, 4);
                shapes[2] = new Parallellogram(4, 6);
                shapes[3] = new Ellips(7, 9);
                shapes[4] = new Square(6);
                
                

            };

            foreach (Geomertri shape in shapes)
            {
                Console.WriteLine(shape.GetArea()); 
            }

        }
    }
}
