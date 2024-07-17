namespace Adapter_Design_Pattern
{
    public class TemperatureAdapter : ITemperature
    {
        private FahrenheitTemperature _fahrenheitTemperature;
        public TemperatureAdapter(FahrenheitTemperature fahrenheitTemperature)
        {
            _fahrenheitTemperature = fahrenheitTemperature;
        }
        public double GetTemperature()
        {
            return (_fahrenheitTemperature.GetTemperatureInFahrenheit() - 32) * 5 / 9;
        }
    }
}
