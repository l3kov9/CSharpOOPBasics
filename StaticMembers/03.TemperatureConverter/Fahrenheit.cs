namespace _03.TemperatureConverter
{
    public class Fahrenheit : Unit
    {
        public Fahrenheit(double temperature) : base(temperature)
        {

        }

        public static double ConverterToCelsius(double temperature)
        {
            return (temperature - 32) * 5 / 9.0;
        }
    }
}
