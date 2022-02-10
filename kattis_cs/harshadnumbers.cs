using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class harshadnumbers
    {
        static void Main(string [] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool harshad = false;

            while (!harshad)
            {
                int sum = 0;
                int c = n;
                while (c != 0)
                {
                    sum += c % 10;
                    c /= 10;
                }
                if (n % sum == 0)
                {
                    harshad = true;
                }
                else
                {
                    n++;
                }
            }
            Console.WriteLine(n);
        }
    }
}
