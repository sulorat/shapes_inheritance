namespace shapes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape shape = new shape();
            triangle triangle = new triangle();
            circle circle = new circle();
            square square = new square();
            rectangle rectangle = new rectangle();
            piramid piramid = new piramid();
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Q - circle\nW - square\nE - rectangle\nR - triangle\nT - pyramid");
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.WriteLine();
                    switch (key)
                    {
                        case ConsoleKey.Q:
                            {
                                Console.WriteLine("Enter radius circle");
                                double circl_radius = double.Parse(Console.ReadLine());
                                circle.get_r(circl_radius);
                                Console.Clear();
                                Console.WriteLine("Perimentr of circle: " + circle.perimetr_found());
                                Console.WriteLine("Area of circle: " + circle.area_found());
                                Console.WriteLine("Press any button to continue");
                                Console.ReadKey();
                                break;
                            }
                        case ConsoleKey.W:
                            {
                                Console.WriteLine("Enter side A for square ");
                                double side_square = double.Parse(Console.ReadLine());
                                square.get_a(side_square);
                                Console.Clear();
                                Console.WriteLine("Perimetr of square: " + square.perimetr_found());
                                Console.WriteLine("Area of square: " + square.area_found());
                                Console.WriteLine("Press any button to continue");
                                Console.ReadKey();
                                break;
                            }
                        case ConsoleKey.E:
                            {
                                Console.WriteLine("Enter side A for rectangle");
                                double side_a_rectangle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side B for rectangle");
                                double side_b_rectangle = double.Parse(Console.ReadLine());
                                rectangle.get_b(side_b_rectangle);
                                rectangle.get_a(side_a_rectangle);
                                Console.Clear();
                                Console.WriteLine("Perimetr of rectangle: " + rectangle.perimetr_found());
                                Console.WriteLine("Area of rectangle: " + rectangle.area_found());
                                Console.WriteLine("Press any button to continue");
                                Console.ReadKey();
                                break;
                            }
                        case ConsoleKey.R:
                            {
                                Console.WriteLine("Enter side 1 for triangle");
                                double side_a_triangle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 2 for triangle");
                                double side_b_triangle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter side 3 for triangle");
                                double side_c_triangle = double.Parse(Console.ReadLine());
                                Console.WriteLine("Enter height for triangle");
                                double height = double.Parse(Console.ReadLine());
                                triangle.get_a(side_a_triangle);
                                triangle.get_b(side_b_triangle);
                                triangle.get_c(side_c_triangle);
                                triangle.get_h(height);
                                if ((side_a_triangle > 0) && (side_b_triangle > 0) && (side_c_triangle > 0))
                                {
                                    if ((side_a_triangle + side_b_triangle < side_c_triangle) || (side_c_triangle + side_b_triangle < side_a_triangle) && (side_a_triangle + side_c_triangle < side_b_triangle))
                                    {
                                        Console.WriteLine("Triangle is not exist");
                                        Console.WriteLine("Press any button to continue");
                                        Console.ReadKey();
                                        break;
                                    }
                                    if ((side_a_triangle > side_b_triangle) && (side_a_triangle > side_c_triangle))
                                    {
                                        if (Math.Pow(side_b_triangle, 2) + Math.Pow(side_c_triangle, 2) == Math.Pow(side_a_triangle, 2))
                                        {
                                            triangle.get_type(2);
                                        }
                                    }
                                    if ((side_b_triangle > side_a_triangle) && (side_b_triangle > side_c_triangle))
                                    {
                                        if (Math.Pow(side_a_triangle, 2) + Math.Pow(side_c_triangle, 2) == Math.Pow(side_b_triangle, 2))
                                        {
                                            triangle.get_type(2);
                                            triangle.get_b(side_c_triangle);
                                        }
                                    }
                                    if ((side_c_triangle > side_b_triangle) && (side_c_triangle > side_a_triangle))
                                    {
                                        if (Math.Pow(side_b_triangle, 2) + Math.Pow(side_a_triangle, 2) == Math.Pow(side_c_triangle, 2))
                                        {
                                            triangle.get_type(2);
                                        }
                                    }
                                    else if ((side_c_triangle == side_b_triangle) && (side_c_triangle == side_a_triangle))
                                    {
                                        triangle.get_type(3);
                                    }
                                    else if ((Math.Pow(side_a_triangle, 2) + Math.Pow(side_b_triangle, 2)) > Math.Pow(side_c_triangle, 2))
                                    {
                                        triangle.get_type(1);
                                    }
                                    else if ((Math.Pow(side_b_triangle, 2) + Math.Pow(side_c_triangle, 2)) > Math.Pow(side_a_triangle, 2))
                                    {
                                        triangle.get_type(1);
                                    }
                                    else if ((Math.Pow(side_a_triangle, 2) + Math.Pow(side_c_triangle, 2)) > Math.Pow(side_b_triangle, 2))
                                    {
                                        triangle.get_type(1);
                                    }
                                    Console.Clear();
                                    Console.WriteLine("Perimetr of triangle: " + triangle.perimetr_found());
                                    Console.WriteLine("Area of triangle: " + triangle.area_found());
                                    Console.WriteLine("Press any button to continue");
                                    Console.ReadKey();
                                }
                                break;
                            }
                        case ConsoleKey.T:
                            {
                                Console.Clear();
                                double piramida;
                                Console.WriteLine("Which type of piramida?\nA - square piramida\nS - Circle piramida\nD - triangle piramida");
                                ConsoleKey need_key = Console.ReadKey().Key;
                                switch (need_key)
                                {
                                    case ConsoleKey.A:
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Enter side of square");
                                            double side_a_square = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter apopheme ");
                                            double height = double.Parse(Console.ReadLine());
                                            piramida = 1;
                                            piramid.get_type(piramida);
                                            square.get_a(side_a_square);
                                            Console.WriteLine("Area of piramida: " + piramid.area_piramid(square.perimetr_found(), 0,0,height, square.area_found()));
                                            Console.WriteLine("Press any button to continue");
                                            Console.ReadKey();
                                            break;
                                        }
                                        case ConsoleKey.S:
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Enter height of lateral face");
                                            double l = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter radius of circle");
                                            double radius = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Area of piramida: " + piramid.area_konus(l, radius));
                                            Console.WriteLine("Press any button to continue");
                                            Console.ReadKey();
                                            break;
                                        }
                                        case ConsoleKey.D: 
                                        {
                                            Console.WriteLine();
                                            triangle.get_type(1);
                                            Console.WriteLine("Enter side of footing triangle");
                                            triangle.get_a(double.Parse(Console.ReadLine()));
                                            Console.WriteLine("Enter height of footing triangle");
                                            triangle.get_h (double.Parse(Console.ReadLine())); 
                                            double s_triangle_1 = triangle.area_found();
                                            Console.WriteLine("Enter apopheme");
                                            triangle.get_h( double.Parse(Console.ReadLine()));
                                            double s_triangle_2 = triangle.area_found();
                                            piramida = 3;
                                            piramid.get_type(piramida);
                                            Console.WriteLine("Area of piramida: " + piramid.area_piramid(0,s_triangle_1,s_triangle_2,0,0));
                                            Console.WriteLine("Press any button to continue");
                                            Console.ReadKey();
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }   
            }
            catch 
            {
                Console.WriteLine("error");
                return;
            }

        }
    }
}