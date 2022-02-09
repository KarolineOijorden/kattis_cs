using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Kolone
    {
        static void Main(string[] args)
        {
            int[] lengths = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
            char[] row1 = Console.ReadLine().ToCharArray();
            Array.Reverse(row1);
            char[] row2 = Console.ReadLine().ToCharArray();
            char[] result = row1.Concat(row2).ToArray();
            string line = string.Join("", result);
            int t = int.Parse(Console.ReadLine());

            int positionRow1 = lengths[0] - 1;
            int positionRow2 = lengths[0];

            while (t > 0)
            {
                if (positionRow1 >= 0)
                {
                    if (t > lengths[1])
                    {
                        result[positionRow1 + lengths[1]] = line[positionRow1];
                    }
                    else
                    {
                        result[positionRow1 + t] = line[positionRow1];
                    }
                }
                if (positionRow2 < result.Length)
                {
                    if (t > lengths[0])
                    {
                        result[positionRow2 - lengths[0]] = line[positionRow2];
                    }
                    else
                    {
                        result[positionRow2 - t] = line[positionRow2];
                    }
                }
                positionRow1--;
                positionRow2++;
                t--;
            }

            foreach (char ch in result)
            {
                Console.Write(ch);
            }
        }
    }
}