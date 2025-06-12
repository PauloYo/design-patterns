namespace StructuralPatterns.Decorator
{
    public class SMSDecorator : NotificationDecorator
    {
        public SMSDecorator(INotification notification) : base(notification) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}