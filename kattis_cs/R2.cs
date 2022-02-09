using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class R2
    {
        static void Main(string [] args)
        {
            int [] numbers = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
            Console.WriteLine(numbers[1] * 2 - numbers[0]);
        }
    }
}
