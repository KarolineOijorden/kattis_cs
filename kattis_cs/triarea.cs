using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class triarea
    {
        static void Main(string [] args)
        {
            double [] numbers = Array.ConvertAll(Console.ReadLine().Split(), s => Convert.ToDouble(s));
            Console.Write(numbers[0] * numbers[1]/ 2);
        }
    }
}
