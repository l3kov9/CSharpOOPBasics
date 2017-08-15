using System;

namespace _06.DateModifier
{
    public class DateModifier
    {
        public DateModifier(DateTime firstDate, DateTime secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
        }

        public int DifferenceInDays()
        {
            if (firstDate < secondDate)
            {
                var newDate = firstDate;
                firstDate = secondDate;
                secondDate = newDate;
            }

            var diff=new DateTime(firstDate.Year-secondDate.Year,firstDate.Month-secondDate.Month,firstDate.Day-secondDate.Day);
            var result = (diff.Year * 365) + (diff.Month * 30) + diff.Day;

            return result;
        }

        private DateTime firstDate;
        private DateTime secondDate;

        public DateTime FirstDate
        {
            get { return this.firstDate; }
            set { this.firstDate = value; }
        }

        public DateTime SecondDate
        {
            get { return this.secondDate; }
            set { this.secondDate = value; }
        }
    }
}
