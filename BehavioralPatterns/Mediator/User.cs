namespace BehavioralPatterns.Mediator
{
    public class User
    {
        public string Name { get; }
        private readonly IMediator _mediator;

        public User(string name, IMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            if (mediator is ChatMediator chatMediator)
            {
                chatMediator.AddUser(this);
            }
        }

        public void SendMessage(string message)
        {
            _mediator.SendMessage(message, this);
        }
    }
}