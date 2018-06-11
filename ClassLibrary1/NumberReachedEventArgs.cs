using System;

namespace Prototypes1
{
    public class NumberReachedEventArgs : EventArgs
    {
        private int _reached;
        public NumberReachedEventArgs(int num)
        {
            this._reached = num;
        }
        public int ReachedNumber
        {
            get
            {
                return _reached;
            }
        }
    }
}