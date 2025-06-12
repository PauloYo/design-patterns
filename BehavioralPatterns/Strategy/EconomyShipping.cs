namespace BehavioralPatterns.Strategy
{
    public class EconomyShipping : IShippingStrategy
    {
        public double Calculate(double weight)
        {
            return weight * 0.1;
        }
    }
}