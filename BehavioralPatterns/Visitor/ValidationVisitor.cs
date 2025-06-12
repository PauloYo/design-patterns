namespace BehavioralPatterns.Visitor
{
    public class ValidationVisitor : IVisitor
    {
        public void Visit(ElementA element)
        {
            Console.WriteLine("Validating ElementA...");
        }

        public void Visit(ElementB element)
        {
            Console.WriteLine("Validating ElementB...");
        }
    }
}