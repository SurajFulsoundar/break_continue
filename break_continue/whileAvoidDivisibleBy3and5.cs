using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace break_continue
{
    // Wc to display number between 1 to 20  avoid no. which is divisible by 3 and 5.
    internal class whileAvoidDivisibleBy3and5
    {
        static void Main(string[] args)
        {
            int i = 1;
            while ( i <= 20)
            {
                
                if(i % 3 == 0 && i % 5 == 0)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
                
            }
        }
    }
}
