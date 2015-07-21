using System;

    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the circle is: {0:F2}", Math.PI * 2 * r);
            Console.WriteLine("The area of the circle is: {0:F2}", Math.PI * r * r);
        }
    }
