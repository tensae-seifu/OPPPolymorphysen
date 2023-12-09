using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphisem
{
    internal class Rectangel:Geomertri
    {
        public double _Width {  get; set; }
        public double _Height { get; set; }  

        public Rectangel(double Width, double Height) 
        {
        
        this._Width = Width;
        this._Height = Height;
        
        }

        public  override float  GetArea()
        {


            Console.Write($"Area Rektangel: ");
            return (float)(Math.Round(_Width * _Height,2));
            
        }
    }
}
