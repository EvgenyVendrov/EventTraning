using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraning
{
    class NonNum
    {
        public static void recivedDataIsNotANum(object source, FinishedRecivingInputEventArgs arg)
        {
            var isNumeric = int.TryParse(arg.dataRecivedFromPublisherClass, out int n);
            if (!isNumeric)
            {
                Console.WriteLine("this is NOT A NUMBER!");
            }
        }
    }
}
