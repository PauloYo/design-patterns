namespace BehavioralPatterns.Strategy
{
    public class LocalShipping : IShippingStrategy
    {
        public double Calculate(double weight)
        {
            return weight * 0.05;
        }
    }
}