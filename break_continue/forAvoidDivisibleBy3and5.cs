using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    internal class forAvoidDivisibleBy3and5
    {

        //Wc to display number between 1 to 20  avoid no. which is divisible by 3 and 5.
        static void Main(string[]args)
        {
            for(int i = 1; i <= 20; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
           
        }
    }
}





