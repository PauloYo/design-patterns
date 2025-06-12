namespace BehavioralPatterns.ChainOfResponsibility
{

    public class ReceiptHandler : DocumentHandler
    {
        public override void Handle(string documentType)
        {
            if (documentType == "Receipt")
            {
                Console.WriteLine("Processing Receipt...");
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