using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Isithalloween
    {
        static void Main(String[] args)
        {
            string[] date = Console.ReadLine().Split();
            if (date[0] == "OCT" && date[1] == "31")
            {
                Console.WriteLine("Yup");
            }
            else if (date[0] == "DEC" && date[1] == "25")
            {
                Console.WriteLine("Yup");
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
    }
}