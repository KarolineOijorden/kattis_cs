using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Nsum
    {
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] values = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result += values[i];
            }
            Console.WriteLine(result);
        }
    }
}
