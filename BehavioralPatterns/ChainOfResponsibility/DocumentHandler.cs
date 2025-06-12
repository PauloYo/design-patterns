namespace BehavioralPatterns.ChainOfResponsibility
{
    public abstract class DocumentHandler
    {
        protected DocumentHandler _nextHandler;

        public DocumentHandler SetNext(DocumentHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public abstract void Handle(string documentType);
    }
}