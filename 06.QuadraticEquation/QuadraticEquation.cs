using System;

    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double determinant = (b * b) - (4 * a * c);

            if (determinant < 0)
            {
                Console.WriteLine("No real roots");
            }
            else if (determinant > 0)
            {
                Console.WriteLine("x1 = {0}", (-b - Math.Sqrt(determinant)) / (2 * a));
                Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(determinant)) / (2 * a));
            }
            else
            {
                Console.WriteLine("x1 = x2 = {0}", (-b / (2 * a)));
            }

        }
    }
