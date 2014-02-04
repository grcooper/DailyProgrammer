using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NutsBolts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numItems = Convert.ToInt16(Console.ReadLine());

            string[] tempList;
            string[] itemList = new string[numItems];
            Dictionary<string, int> oInv = new Dictionary<string, int>();
            Dictionary<string, int> fInv = new Dictionary<string, int>();
            Dictionary<string, int> cInv = new Dictionary<string,int>();

            for (int i = 0; i < numItems; i++)
            {
                tempList = Console.ReadLine().Split(' ');

                oInv.Add(tempList[0], Convert.ToInt16(tempList[1]));
                itemList[i] = tempList[0];
            }

            for (int p = 0; p < numItems; p++)
            {
                tempList = Console.ReadLine().Split(' ');

                fInv.Add(tempList[0], Convert.ToInt16(tempList[1]));
            }

            for (int q = 0; q < numItems; q++)
            {
                string tempName = itemList[q];
                int start = oInv.FirstOrDefault(x => x.Key == tempName).Value;
                int end = fInv.FirstOrDefault(x => x.Key == tempName).Value;
                if (start != end)
                {
                    cInv.Add(tempName, end - start);
                }
            }

            foreach (KeyValuePair<string, int> pair in cInv)
            {
                Console.WriteLine("{0} {1}",
                pair.Key,
                pair.Value);
            }

            Console.ReadKey();
        }
    }
}
