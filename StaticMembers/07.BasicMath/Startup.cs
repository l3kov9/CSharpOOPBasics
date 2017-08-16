using System;

namespace _07.BasicMath
{
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                var commands = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "End": return;
                    case "Sum": Console.WriteLine(MathUtil.Sum(commands[1], commands[2]));
                        break;
                    case "Subtract": Console.WriteLine(MathUtil.Subtract(commands[1], commands[2]));
                        break;
                    case "Multiply": Console.WriteLine(MathUtil.Multiply(commands[1], commands[2]));
                        break;
                    case "Divide": Console.WriteLine(MathUtil.Divide(commands[1], commands[2]));
                        break;
                    case "Percentage": Console.WriteLine(MathUtil.Percentage(commands[1], commands[2]));
                        break;
                    default:
                        break;
                }
            } 
        }
    }
}
