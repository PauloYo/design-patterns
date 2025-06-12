namespace StructuralPatterns.Bridge
{
    // Concrete implementations
    public class RedColor : IColor
    {
        public string ApplyColor()
        {
            return "red";
        }
    }
}