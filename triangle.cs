using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class triangle : shape
    {
        private double a, b, c, h;
        private int type;
        public void get_a(double a)
        {
            this.a = a;
        }
        public void get_b(double b)
        {
            this.b = b;
        }

        public void get_c(double c)
        {
            this.c = c;
        }
        public void get_type(int type)
        {
            this.type = type;
        }
        public void get_h(double h)
        {
            this.h = h;
        }
        public override double perimetr_found()
        {
            perimetr = a + b + c;
            return base.perimetr_found();
        }
        public override double area_found()
        {
            if (type == 1)
            {
                area = (a * h) / 2;
                return base.area_found();
            }
            if (type == 2)
            {
                area = (a * b) / 2;
                return base.area_found();
            }
            if (type == 3)
            {
                area = (Math.Pow(a, 2) * Math.Sqrt(3)) / 4;
                return base.area_found();
            }
            return base.area_found();
        }
    }
}
