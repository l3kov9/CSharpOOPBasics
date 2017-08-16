using System;

namespace _03.TemperatureConverter
{
    public class Startup
    {
        public static void Main()
        {
            while (true)
            {
                var temperatureInfo = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                if (temperatureInfo[0] == "End")
                {
                    break;
                }

                var temperature = double.Parse(temperatureInfo[0]);
                var value = temperatureInfo[1];

                if (value == "Celsius")
                {
                    Console.WriteLine($"{Celsius.ConverterFahrenheit(temperature):f2} Fahrenheit");
                }
                else if (value == "Fahrenheit")
                {
                    Console.WriteLine($"{Fahrenheit.ConverterToCelsius(temperature):f2} Celsius");
                }
            }
        }
    }
}
