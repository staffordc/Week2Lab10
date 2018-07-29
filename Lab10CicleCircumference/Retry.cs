using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise43CalcDistance
{
    static class RetryPrompt
    {
        public static bool Retry()
        {
            Console.WriteLine("\ncontinue? yes or no please.");
            String Answer = Console.ReadLine().ToUpper();

            if (Answer == "Y" || Answer == "YES")
            {
                return true;
            }
            else if (Answer == "N" || Answer == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\ni don't know that. please input y or n.");
                return Retry();
            }
        }
    }
}
