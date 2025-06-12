namespace BehavioralPatterns.ChainOfResponsibility
{
    public class BillHandler : DocumentHandler
    {
        public override void Handle(string documentType)
        {
            if (documentType == "Bill")
            {
                Console.WriteLine("Processing Bill...");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.Handle(documentType);
            }
            else
            {
                Console.WriteLine($"Cannot process {documentType}.");
            }
        }
    }
}