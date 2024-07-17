namespace Adapter_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Celsius Temperature: ");
                double CT = double.Parse(Console.ReadLine());
                ITemperature celsiusTemperature = new CelsiusTemperature(CT);
                Console.WriteLine($"Temperature in Celsius: {celsiusTemperature.GetTemperature()}°C");

                Console.Write("Enter Fahrenheit Temperature: ");
                double FT = double.Parse(Console.ReadLine());
                FahrenheitTemperature fahrenheitTemperature = new FahrenheitTemperature(FT);

                ITemperature adaptedTemperature = new TemperatureAdapter(fahrenheitTemperature);
                Console.WriteLine($"Temperature in Celsius (using adapter): {adaptedTemperature.GetTemperature()}°C");
                Console.WriteLine("----------------------------------------------------------------------");
            }
        }
    }
}