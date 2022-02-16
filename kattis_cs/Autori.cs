using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Autori
    {
        static void Main(string [] args)
        {
            string [] names = Console.ReadLine().Split('-');
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i][0]);
            }
        }
    }
}
