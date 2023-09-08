using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    internal class AverageOfDigitNumber
    {
        static void Main(string[] args)
        {
            //  Find the avg of digit from the number.

            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int count = 0;
            int avg = 0;
            int remd = 0;                          // num = 1234;

            while (num != 0)
            {
                 remd = num % 10;
                sum = sum + remd;
                count++;

                num = num / 10;


            }
            avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
