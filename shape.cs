using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class shape
    {
        protected double area;
        protected double perimetr;
        public virtual double perimetr_found()
        {
            return perimetr;
        }
        public virtual double area_found() 
        {  
            return area; 
        }
    }
}
