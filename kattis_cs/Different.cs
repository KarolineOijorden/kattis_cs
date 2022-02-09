using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Different
    {
        static void Main(String[] args)
        {
            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                string[] values = line.Split();
                Console.WriteLine(Math.Abs(Convert.ToInt64(values[0]) - Convert.ToInt64(values[1])));
            }
        }
    }
}
