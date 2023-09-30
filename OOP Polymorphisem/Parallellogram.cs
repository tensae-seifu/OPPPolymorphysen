using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphisem
{
    internal class Parallellogram:Geomertri
    {
        public double _Base {  get; set; }  
        public double _Height {  get; set; }    

        public Parallellogram(double Base,double Height):base(0) 
        {
            this._Base = Base;
            this._Height = Height;
        
        
        }

        public override float GetArea()
        {

            Console.Write($"Area Parallelogram: ");
            return (float)(Math.Round(_Base * _Height, 2));

            
        }
    }

    
}
