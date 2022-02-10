using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class sumkindofproblem
    {
        public static void Main(string [] args)
        {
            int p = int.Parse(Console.ReadLine());
            for (int i = 1; i <= p; i++)
            {
                string [] input = Console.ReadLine().Split();
                int n = int.Parse(input[1]);
                int s3 = n * (n + 1);
                int s2 = n * n;
                int s1 = s3 / 2;

                Console.Write(i + " " + s1 + " " + s2 + " " + s3);
                Console.WriteLine();
            }
        }
    }
}
