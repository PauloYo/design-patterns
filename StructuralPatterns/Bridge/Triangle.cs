namespace StructuralPatterns.Bridge
{
    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {_color.ApplyColor()} triangle");
        }
    }
}