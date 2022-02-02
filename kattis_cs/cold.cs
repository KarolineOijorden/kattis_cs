using System;

namespace kattiscs
{
    class Cold
    {
        static void Main(string[] args)
        {
            int nTemperatures = int.Parse(Console.ReadLine());
            int[] temperatures = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int colddays = 0;

            for (int i = 0; i < nTemperatures; i++)
            {
                if (temperatures[i] < 0)
                {
                    colddays++;
                }
            }
            Console.WriteLine(colddays);
        }
    }
}