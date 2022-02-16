using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class aboveaverage
    {
        static void Main(string [] args)
        {
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                int [] grades = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                double averageGrade = (grades.Sum() - grades[0]) / grades[0];
                int above = 0;
                for (int j = 1; j < grades.Length; j++)
                {
                    if (grades[j] > averageGrade)
                    {
                        above++;
                    }
                }
                Console.WriteLine("{0}%", ((double)above / grades[0] * 100).ToString("0.000"));
            }
        }
    }
}
