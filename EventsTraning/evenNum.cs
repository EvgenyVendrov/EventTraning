using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraning
{
    class EvenNum
    {
        public static void recivedDataIsEven(object source,FinishedRecivingInputEventArgs arg)
        {
            var isNumeric = int.TryParse(arg.dataRecivedFromPublisherClass, out int n);
            if (isNumeric)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("the number is EVEN!");
                }
            }
        }
    }
}
