using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsTraning
{
    class Publisher
    {
        public event EventHandler<FinishedRecivingInputEventArgs> FinishedRecivingInput;
        private string _data;
        public void ReciveData()
        {
            Console.WriteLine("please enter the data :)");
            _data = Console.ReadLine();
            OnFinishedRecivingInput(new FinishedRecivingInputEventArgs() { dataRecivedFromPublisherClass = _data });

        }
        protected virtual void OnFinishedRecivingInput(FinishedRecivingInputEventArgs arg)
        {
            if (FinishedRecivingInput != null)
            {
                FinishedRecivingInput(this, arg);
            }
        }
    }
}