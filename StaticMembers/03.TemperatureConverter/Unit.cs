namespace _03.TemperatureConverter
{
    abstract public class Unit
    {
        private double temperature;

        public double Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }
        }

        public double Convert(double temperature)
        {
            return 0d;
        }

        protected Unit(double temperature)
        {
            this.temperature = temperature;
        }

        public static double Converter(double num)
        {
            return 0d;
        }
    }
}
