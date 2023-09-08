using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace break_continue
{
    internal class divisibleBy11Stop
    {
        // Wc display number between 1 to 25 it any number divisible by 11 then stop the the dispaly process.
        static void Main(string[] args)
        {
            for(int i =1; i <= 25; i++)
            {
                if(i % 11 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
