namespace BehavioralPatterns.Strategy
{
    public class ShippingCalculator
    {
        private IShippingStrategy _strategy;

        public ShippingCalculator(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }

        public double Calculate(double weight)
        {
            return _strategy.Calculate(weight);
        }
    }
}