namespace StructuralPatterns.Bridge
{
    // Refined abstractions
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {_color.ApplyColor()} circle");
        }
    }
}