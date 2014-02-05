using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FallingSand
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt16(Console.ReadLine());

            string[,] grid = new string[size, size];
            string[] line = new string[size];
            string[,] newGrid = new string[size, size];

            

            for (int i = 0; i < size; i++)
            {
                line = Console.ReadLine().Split();
                for (int q = 0; q < size; q++)
                {
                    grid[i, q] = line[q];
                }
            }

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (grid[x, y] == ".")
                    {
                        if (grid[x, y + 1] == "#")
                        {
                            newGrid[x, y] = ".";
                        }
                        else
                        {
                            grid[x, y + 1] = ".";
                            newGrid[x, y] = " ";
                        }
                    }
                    else if (grid[x, y] == "#")
                    {
                        newGrid[x, y] = "#";
                    }
                    else
                    {
                        newGrid[x, y] = " ";
                    }
                }
            }
            
            for (int m = 0; m < size; m++)
            {
                for (int n = 0; n < size; n++)
                {
                    Console.WriteLine(newGrid[m, n]);
                }
            }
            



        }
    }
}
