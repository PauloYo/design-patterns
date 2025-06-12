namespace StructuralPatterns.Decorator
{
    public abstract class NotificationDecorator : INotification
    {
        protected INotification _notification;

        protected NotificationDecorator(INotification notification)
        {
            _notification = notification;
        }

        public virtual void Send(string message)
        {
            _notification.Send(message);
        }
    }
}