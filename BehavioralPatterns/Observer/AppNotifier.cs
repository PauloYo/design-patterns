namespace BehavioralPatterns.Observer
{
    public class AppNotifier : IObserver
    {
        public void Update(string status)
        {
            Console.WriteLine($"App: Your order is now {status}.");
        }
    }
}