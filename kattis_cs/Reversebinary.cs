using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kattis_cs
{
    class Reversebinary
    {
        public static void Main(string [] args)
        {
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = "";
            while (number > 0)
            {
                int remainder = number % 2;
                binaryNumber += remainder.ToString();
                number /= 2;
            }
            double newNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                newNumber += Convert.ToInt32(Char.GetNumericValue(binaryNumber[i]) * Math.Pow(2, binaryNumber.Length - i - 1));
            }
            Console.WriteLine(newNumber);
        }
    }
}
