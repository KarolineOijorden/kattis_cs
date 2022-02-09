using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Greetings2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("h" + new string('e', Console.ReadLine().Count(c => c == 'e') * 2) + "y");
        }
    }
}