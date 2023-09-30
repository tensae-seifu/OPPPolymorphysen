using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphisem
{
    internal class Ellips:Geomertri
    {
        public double _A { get; set; }
        public double _B { get; set; }

        public Ellips(double A, double B):base(0)
        {
         this._A = A;
         this._B = B;    
        
        }

        public override float GetArea()
        {

            Console.Write($"Area Elipse: ");

            return (float)(Math.Round(Math.PI * _A * _B,2));
         
        }
    }
}
