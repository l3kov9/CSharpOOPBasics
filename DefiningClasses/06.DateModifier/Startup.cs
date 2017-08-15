using System;

namespace _06.DateModifier
{
    public class Startup
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var firstDateyear = int.Parse(firstDate[0]);
            var firstDatemonth = int.Parse(firstDate[1]);
            var firstDateday = int.Parse(firstDate[2]);
            var firstDataTime=new DateTime(firstDateyear,firstDatemonth,firstDateday);

            var secondDate = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var secondDateyear = int.Parse(firstDate[0]);
            var secondDatemonth = int.Parse(firstDate[1]);
            var secondDateday = int.Parse(firstDate[2]);
            var secondDateTime = new DateTime(secondDateyear, secondDatemonth, secondDateday);

            var checkDifference=new DateModifier(firstDataTime,secondDateTime).DifferenceInDays();

            Console.WriteLine(checkDifference);
        }
    }
}
