using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_2
{
    internal class piramid : shape
    {
        private double type;
        public void get_type(double type)
        {
            this.type = type;
        }
        public double area_konus(double l, double r)
        {
            area = Math.PI * r * (r + l);
            return base.area_found();
        }
        public double area_piramid(double per_square, double s_triangle, double s_triangle_2, double height, double s_square)
        {
            if (type == 1)
            {
                area = +(0.5 * per_square * height + s_square);
            }
            if (type == 3)
            {
                area = s_triangle + 3 * s_triangle_2;
            }
            return area;
        }
    }
}
