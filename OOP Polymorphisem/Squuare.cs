using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphisem
{
    internal class Square:Geomertri
    {

        public double _Side {  get; set; }  

        public Square (double Side)
        {
            this._Side = Side;
        }

        public override float GetArea()
        {
            Console.Write($"Area Fyrkant: ");
            return (float)(Math.Round(_Side*_Side,2));
        }
    }
}
