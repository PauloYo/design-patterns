namespace StructuralPatterns.Adapter
{
    // Adapters
    public class SensorAAdapter : ITemperatureSensor
    {
        private readonly SensorA _sensor;

        public SensorAAdapter(SensorA sensor)
        {
            _sensor = sensor;
        }

        public double ReadTemperature()
        {
            return _sensor.GetTemperatureInCelsius();
        }
    }
}