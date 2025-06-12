namespace StructuralPatterns.Decorator
{
    public class BaseNotification : INotification
    {
        public virtual void Send(string message)
        {
            Console.WriteLine($"Base notification: {message}");
        }
    }
}