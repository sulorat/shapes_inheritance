using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class rectangle : shape
    {
        private double a, b;
        public void get_ab(double a,double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double perimetr_found()
        {
            perimetr = (a * 2) + (b * 2);
            return base.perimetr_found();
        }
        public override double area_found()
        {
            area = a * b;
            return base.area_found();
        }
    }
}
