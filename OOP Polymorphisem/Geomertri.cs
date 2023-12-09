using OOP_Polymorphisem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphisem
{
    internal class Geomertri
    {

        public float _Area {  get; set; }   
         

        //public Geomertri(float Area) 
        
        //{ 
        // this._Area = Area;
        
        
        
        //}  

        public virtual float GetArea()

        {
            return _Area;
        }

      
    }
}


