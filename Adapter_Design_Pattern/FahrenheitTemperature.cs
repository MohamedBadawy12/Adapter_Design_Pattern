namespace Adapter_Design_Pattern
{
    public class FahrenheitTemperature
    {
        private double _temperature;
        public FahrenheitTemperature(double temperature)
        {
            _temperature = temperature;
        }
        public double GetTemperatureInFahrenheit()
        {
            return _temperature;
        }
    }
}
