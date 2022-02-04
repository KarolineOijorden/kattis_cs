using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Cetvrta
    {
        static void Main(string [] args)
        {
            string[] coordinates1 = Console.ReadLine().Split();
            string[] coordinates2 = Console.ReadLine().Split();
            string[] coordinates3 = Console.ReadLine().Split();

            string x;
            string y;

            if (coordinates1[0] == coordinates2[0])
            {
                x = coordinates3[0];
            } else
            {
                if (coordinates1[0] == coordinates3[0])
                {
                    x = coordinates2[0];
                } else
                {
                    x = coordinates1 [0];
                }
            }

            if (coordinates1[1] == coordinates2[1])
            {
                y = coordinates3[1];
            }
            else
            {
                if (coordinates1[1] == coordinates3[1])
                {
                    y = coordinates2[1];
                }
                else
                {
                    y = coordinates1[1];
                }
            }

            Console.WriteLine(x + " " + y);
        }
    }
}
