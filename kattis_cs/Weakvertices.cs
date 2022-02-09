using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Weakvertices
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result;
            while (n != -1)
            {
                int[,] edges = new int[n, 2];
                result = "";
                for (int i = 0; i < n; i++)
                {
                    int [] row = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                }
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
