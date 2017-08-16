using System;

namespace Demo
{
    public class Englishman
    {
        private static int referendumQueueCount;
        private static int refCountPlusFive;
        private int queuePosition;

        public Englishman()
        {
            this.queuePosition = ++referendumQueueCount;
        }

        static Englishman()
        {
            referendumQueueCount=new Random().Next(20);
            refCountPlusFive = 5 + referendumQueueCount;
        }

    }
}
