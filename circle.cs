using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class circle : shape
    {
        private double r;
        public void get_r(double r)
        {
            this.r = r;
        }
        public override double perimetr_found()
        {
            perimetr = 2 * (Math.PI * r);
            return base.perimetr_found();
        }
        public override double area_found()
        {
            area = Math.PI * Math.Pow(r, 2);
            return base.area_found();
        }
    }
}
