using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asuming that the size of the tree is an odd number
            //greater than 1
            string[] input;
            string t, s;
            string line = "";
            string space = "";
            int size, height;

            input = Console.ReadLine().Split(' ');

            size = Convert.ToInt16(input[0]);
            s = input[1];
            t = input[2];
            height = (size + 1) / 2;

            for (int y = 0; y < height; y++)
            {
                for (int i = (size - 1) / 2 - y; i > 0; i--)
                {
                    space += " ";
                }
                for (int q = 0; q <= (2 * y); q++)
                {
                    line += t;
                }
                Console.WriteLine(space + line);
                line = "";
                space = "";
            }

            space = "";
            for (int y = 0; y < ((size - 1) / 2) - 1; y++)
            {
                space += " ";
            }

            Console.WriteLine(space + s + s + s);
            Console.ReadKey();
        }
    }
}
