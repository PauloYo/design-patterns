namespace StructuralPatterns.Adapter
{
    public class SensorBAdapter : ITemperatureSensor
    {
        private readonly SensorB _sensor;

        public SensorBAdapter(SensorB sensor)
        {
            _sensor = sensor;
        }

        public double ReadTemperature()
        {
            return _sensor.ObtenerTemperaturaEnCentigrados();
        }
    }
}