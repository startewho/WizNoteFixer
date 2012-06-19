using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventCounter
{
    class NumberReachedEventArgs:EventArgs
    {
        private int _reached;
        public int ReachedNumber { get { return _reached; } }
        public NumberReachedEventArgs(int num)
        {
            this._reached=num;
        }
    }
}
