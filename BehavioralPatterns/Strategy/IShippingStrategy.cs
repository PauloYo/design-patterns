namespace BehavioralPatterns.Strategy
{
    public interface IShippingStrategy
    {
        double Calculate(double weight);
    }
}