namespace _03.TemperatureConverter
{
    public class Celsius : Unit
    {
        public Celsius(double temperature) : base(temperature)
        {

        }

        public static double ConverterFahrenheit(double temperature)
        {
            return temperature * 9 / 5 + 32;
        }
    }
}
