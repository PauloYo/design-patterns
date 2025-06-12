namespace StructuralPatterns.Decorator
{
    public class PushDecorator : NotificationDecorator
    {
        public PushDecorator(INotification notification) : base(notification) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Push notification sent: {message}");
        }
    }
}