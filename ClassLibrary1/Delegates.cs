using System;

namespace Prototypes1
{
    public delegate void NumberReachedEventHandler(object sender, NumberReachedEventArgs e);

    public class Counter
    {
        public event NumberReachedEventHandler NumberReached;
        public int reachableNum;

        public Counter(int myCounter)
        {
            reachableNum = myCounter;
        }

        public void CountTo(int countTo, int reachableNum)
        {
            if (countTo < reachableNum)
                throw new ArgumentException("reachableNum should be less than countTo");
            for (int ctr = 0; ctr <= countTo; ctr++)
            {
                if (ctr == reachableNum)
                {
                    NumberReachedEventArgs e = new NumberReachedEventArgs(reachableNum);
                    OnNumberReached(e);
                    return;
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