namespace BehavioralPatterns.Mediator
{
    public interface IMediator
    {
        void SendMessage(string message, User user);
    }
}