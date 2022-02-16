using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class filip
    {
        static void Main(string [] args)
        {
            string [] input = Console.ReadLine().Split();
            string x = "";
            string y = "";
            for (int i = 2; i >= 0; i--)
            {
                x += input[0][i];
                y += input[1][i];
            }
            if (int.Parse(x) > int.Parse(y))
            {
                Console.WriteLine(x);
            } else
            {
                Console.WriteLine(y);
            }
        }
    }
}
