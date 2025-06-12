namespace BehavioralPatterns.Visitor
{
    public class ElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}