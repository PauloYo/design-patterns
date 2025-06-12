namespace StructuralPatterns.Adapter
{
    // Adaptees (existing sensors with different APIs)
    public class SensorA
    {
        public double GetTemperatureInCelsius()
        {
            return 25.5; // Simulated temperature
        }
    }
}