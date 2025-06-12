namespace StructuralPatterns.Adapter
{
    public class TemperatureMonitor
    {
        public void DisplayTemperature(ITemperatureSensor sensor)
        {
            Console.WriteLine($"Temperature: {sensor.ReadTemperature()}°C");
        }
    }
}