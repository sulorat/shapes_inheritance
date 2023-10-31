using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class square : shape
    {
        private double a;
        public void get_a(double a)
        {
            this.a = a;
        }
        public override double perimetr_found()
        {
            perimetr = a * 4;
            return base.perimetr_found();
        }
        public override double area_found()
        {
            area = Math.Pow(a, 2);
            return base.area_found();
        }
    }
}
