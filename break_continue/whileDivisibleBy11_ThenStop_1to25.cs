using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    internal class whileDivisibleBy11_ThenStop_1to25
    {
        // Wc display number between 1 to 25 it any number divisible by 11 then stop the the dispaly process.
        static void Main(string[] args)
        {
            int i = 1;
            while(i <= 25)
            {
                if(i % 11 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;



            }
        }
    }
}
