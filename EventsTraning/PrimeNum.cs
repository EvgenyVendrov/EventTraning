using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraning
{
    class PrimeNum
    {
        public static void recivedDataIsPrime(object source, FinishedRecivingInputEventArgs arg)
        {
            var isNumeric = int.TryParse(arg.dataRecivedFromPublisherClass, out int n);
            if (isNumeric)
            {
                if (isPrime(n))
                {
                    Console.WriteLine("the number is PRIME!");
                }
            }
        }

        private static bool isPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for(var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0 && n != i)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
