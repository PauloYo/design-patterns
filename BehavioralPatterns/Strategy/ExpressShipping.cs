namespace BehavioralPatterns.Strategy
{
    public class ExpressShipping : IShippingStrategy
    {
        public double Calculate(double weight)
        {
            return weight * 0.25;
        }
    }
}