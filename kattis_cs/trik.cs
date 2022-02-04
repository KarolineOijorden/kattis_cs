using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class trik
    {
        public static void Main(string [] args)
        {
            string moves = Console.ReadLine();
            int ball = 1;
            int position1;
            int position2;
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'A')
                {
                    position1 = 1;
                    position2 = 2;
                }
                else if (moves[i] == 'B')
                {
                    position1 = 2;
                    position2 = 3;
                }
                else
                {
                    position1 = 1;
                    position2 = 3;
                }

                if (ball == position1)
                {
                    ball = position2;
                } else if (ball == position2)
                {
                    ball = position1;
                }
            }
            Console.WriteLine(ball);
        }
    }
}
