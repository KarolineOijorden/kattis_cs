using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Quadrant
    {
        static void Main(string[] args)
        {
            bool xPositive = int.Parse(Console.ReadLine()) > 0;
            bool yPositive = int.Parse(Console.ReadLine()) > 0;
            int quadrant = -1;
            if (xPositive && yPositive)
            {
                quadrant = 1;
            }
            else if (!xPositive && yPositive)
            {
                quadrant = 2;
            }
            else if (!xPositive && !yPositive)
            {
                quadrant = 3;
            }
            else if (xPositive && !yPositive)
            {
                quadrant = 4;
            }
            Console.WriteLine(quadrant);
        }
    }
}