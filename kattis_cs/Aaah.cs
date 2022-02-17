using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Aaah
    {
        static void Main(string [] args)
        {
            string a = Console.ReadLine();
            if (a.Length >= Console.ReadLine().Length)
            {
                Console.WriteLine("go");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
