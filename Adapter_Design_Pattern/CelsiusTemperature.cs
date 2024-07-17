namespace Adapter_Design_Pattern
{
    public class CelsiusTemperature : ITemperature
    {
        private double _temperature;
        public CelsiusTemperature(double temperature)
        {
            _temperature = temperature;
        }
        public double GetTemperature()
        {
            return _temperature;
        }
    }
}
