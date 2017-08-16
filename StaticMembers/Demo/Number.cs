namespace Demo
{
    public class Number
    {
        //private static int tripleNumber;

        //public static int TripleNumber
        //{
        //    get { return Number.tripleNumber; }
        //}
        private int num;

        public int Num { get { return this.num; } }

        public Number(int num)
        {
            this.num = num;
        }

        public static int Triple(int number)
        {
            return number*3;
        }
    }
}
