namespace StructuralPatterns.Decorator
{
    public class EmailDecorator : NotificationDecorator
    {
        public EmailDecorator(INotification notification) : base(notification) { }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Email sent: {message}");
        }
    }
}