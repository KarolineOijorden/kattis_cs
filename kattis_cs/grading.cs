using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class grading
    {
        static void Main(string[] args)
        {
            int[] scale = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
            int score = int.Parse(Console.ReadLine());
            char grade;
            if (score >= scale[0])
            {
                grade = 'A';
            }
            else if (score >= scale[1])
            {
                grade = 'B';
            }
            else if (score >= scale[2])
            {
                grade = 'C';
            }
            else if (score >= scale[3])
            {
                grade = 'D';
            }
            else if (score >= scale[4])
            {
                grade = 'E';
            }
            else
            {
                grade = 'F';
            }

            Console.Write(grade);
        }
    }
}

rss feed f