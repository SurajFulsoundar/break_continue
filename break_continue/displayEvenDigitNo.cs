using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    internal class displayEvenDigitNo
    {
        // Wc to display even digit from the number of user.
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            

            while(num != 0)
            {
                int remd = num % 10;
                if(remd % 2 == 0)
                {
                    Console.WriteLine(remd);
                }
                num = num / 10;
            }



        }
    }
}

