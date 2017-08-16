namespace _07.BasicMath
{
    public class MathUtil
    {
        public static string Sum(string firstNumber, string secondNumber)
        {
            return $"{decimal.Parse(firstNumber) + decimal.Parse(secondNumber):f2}";
        }

        public static string Subtract(string firstNumber, string secondNumber)
        {
            return $"{decimal.Parse(firstNumber) - decimal.Parse(secondNumber):f2}";
        }

        public static string Multiply(string firstNumber, string secondNumber)
        {
            return $"{decimal.Parse(firstNumber) * decimal.Parse(secondNumber):f2}";
        }

        public static string Divide(string firstNumber, string secondNumber)
        {
            return $"{decimal.Parse(firstNumber) / decimal.Parse(secondNumber):f2}";
        }

        public static string Percentage(string number, string percentOfNumber)
        {
            return $"{decimal.Parse(number) * decimal.Parse(percentOfNumber)/100:f2}";
        }
    }
}
