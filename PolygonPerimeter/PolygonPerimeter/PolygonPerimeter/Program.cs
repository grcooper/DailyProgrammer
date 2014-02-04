using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolygonPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sinput = new string[2];
            int n;
            float r, angle;
            double side, p;

            sinput = Console.ReadLine().Split(' ');

            n = Convert.ToInt16(sinput[0]);
            r = float.Parse(sinput[1]);

            angle = 360 / n;

            side = cosLaw(r, r, angle);
            p = side * n;

            Console.WriteLine(side);
            Console.ReadKey();
           
        }

        static double cosLaw(float s1, float s2, float a)
        {
            return Math.Sqrt((s1 * s1) + (s2 * s2) - (2 * s1 * s2 * Math.Cos(a)));
        }
    }
}
