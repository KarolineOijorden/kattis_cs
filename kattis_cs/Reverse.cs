using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Reverse
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = n-1; i >= 0; i--)
            {
                sb.Insert(0, Console.ReadLine() + "\n");
            }
            Console.WriteLine(sb);
        }
    } 
}