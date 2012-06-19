using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventCounter
{
    class Count
    {
        public event EventHandler<NumberReachedEventArgs> NumberReached;
        public Count()
        {

        }

        public void CountTo(int countTo, int reachableNum)
        {
            if (countTo < reachableNum)
                throw new ArgumentException("reachableNumb should be less than countTo number");
            for (int ctr = 0; ctr < countTo; ctr++)
            {
                if (ctr == reachableNum)
                {
                    NumberReachedEventArgs e = new NumberReachedEventArgs(reachableNum);
                    OnNumberReached(e);
                }
            }
        }

        protected virtual void OnNumberReached(NumberReachedEventArgs e)
        {
            if (NumberReached != null)
            {
                NumberReached(this, e);
            }
        }
    }
}
