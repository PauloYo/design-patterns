namespace BehavioralPatterns.ChainOfResponsibility
{
    public class InvoiceHandler : DocumentHandler
    {
        public override void Handle(string documentType)
        {
            if (documentType == "Invoice")
            {
                Console.WriteLine("Processing Invoice...");
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